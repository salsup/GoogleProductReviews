using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {

           //this is a lookup for sku to product link, mfgid, gtin
            var productPath = @"PATH TO PRODUCTS";
            //product reviews
            var reviewPath = @"PATH TO REVIEWS";
            //directory to write file ex. C:\
            var fileWitePath = @"OUTPUT DIRECTORY";

            var reviewsDt = GetDataTableFromCsv(reviewPath, true);
            var prodLookup = GetDataTableFromCsv(productPath, true);

            var feed = new Models.feed();
            var pub = new Models.feedPublisher();
            pub.name = "Company Name";
            feed.publisher = pub;
            var reviewArray = new Models.feedReview[reviewsDt.Rows.Count];
            int count = 0;
            foreach (DataRow r in reviewsDt.Rows)
            {
                try
                {
                    //only do approved reviews (column approved)
                    if (r.Field<string>("approved").Equals("0")) continue;

                    var gtin = (from prod in prodLookup.AsEnumerable()
                               where prod.Field<string>("id") == r.Field<string>("id")
                               select prod.Field<string>("mfgid")).First();
                    var url = (from prod in prodLookup.AsEnumerable()
                                where prod.Field<string>("id") == r.Field<string>("id")
                                select prod.Field<string>("url_link")).First();

                    var review = new Models.feedReview();

                    //review id
                    review.review_id = ushort.Parse(r.Field<string>("reviewid").ToString());
                    review.reviewer = new Models.feedReviewReviewer();
                    review.reviewer.name = new Models.feedReviewReviewerName();
                    review.reviewer.name.is_anonymous = true;
                    review.reviewer.name.is_anonymousSpecified = true;
                    //review user
                    review.reviewer.name.Value = CleanEntry(r.Field<string>("user_name").ToString() ?? "");

                    //review content
                    review.title = CleanEntry(r.Field<string>("short_review").ToString());
                    review.content = CleanEntry(r.Field<string>("long_review").ToString());
                    review.review_timestamp = Convert.ToDateTime(r.Field<string>("review_date"));

                    //review url and type
                    review.review_url = new Models.feedReviewReview_url();
                    review.review_url.Value = url;
                    review.review_url.type = "group";

                    //create rating value
                    review.ratings = new Models.feedReviewRatings();
                    review.ratings.overall = new Models.feedReviewRatingsOverall();
                    review.ratings.overall.max = 5;
                    review.ratings.overall.min = 0;
                    review.ratings.overall.Value = decimal.Parse(r.Field<string>("rating").ToString());

                    //create product review
                    review.products = new Models.feedReviewProducts();
                    review.products.product = new Models.feedReviewProductsProduct();
                    review.products.product.product_ids = new Models.feedReviewProductsProductProduct_ids();
                    review.products.product.product_ids.gtins = new Models.feedReviewProductsProductProduct_idsGtins();
                    review.products.product.product_ids.gtins.gtin = ulong.Parse(gtin.ToString());
                    review.products.product.product_ids.skus = new Models.feedReviewProductsProductProduct_idsSkus();
                    review.products.product.product_ids.skus.sku = r.Field<string>("id");
                    review.products.product.product_ids.brands = new Models.feedReviewProductsProductProduct_idsBrands();
                    review.products.product.product_ids.brands.brand = "Roscoe Medical";
                    review.products.product.product_ids.mpns = new Models.feedReviewProductsProductProduct_idsMpns();
                    review.products.product.product_ids.mpns.mpn = gtin.ToString();

                    reviewArray[count] = review;
                    count++;

                }
                catch (Exception ex)
                {
                    continue;
                }
            }

            feed.reviews = reviewArray;
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(feed.GetType());
                serializer.Serialize(stringwriter, feed);
                string newHeader = "<?xml version=\"1.0\" encoding=\"UTF-16\"?><feed xmlns: vc=\"http://www.w3.org/2007/XMLSchema-versioning\"xmlns: xsi =\"http://www.w3.org/2001/XMLSchema-instance\" xsi: noNamespaceSchemaLocation=\"http://www.google.com/shopping/reviews/schema/product/2.1/product_reviews.xsd\">";
                var s = stringwriter.ToString().Replace("<?xml version=\"1.0\" encoding=\"UTF - 8\"?>", newHeader);
                File.WriteAllText(Path.Combine("","GoogleReview", DateTime.Now.ToString("yyyyMMddHHmmssfff"), ".xml"), s);
            }


        }
        static string CleanEntry(string input)
        {
            input = RemoveInvalidXmlChars(input);
            input = RemoveUnicode(input);
            input = input.Replace("'", "&apos;");
            return input;
        }
        static string RemoveInvalidXmlChars(string text)
        {
            var validXmlChars = text.Where(ch => XmlConvert.IsXmlChar(ch)).ToArray();
            return new string(validXmlChars);
        }
        public static string CleanInvalidXmlChars(string text)
        {
            // From xml spec valid chars: 
            // #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]     
            // any Unicode character, excluding the surrogate blocks, FFFE, and FFFF. 
            string re = @"[^\x09\x0A\x0D\x20-\uD7FF\uE000-\uFFFD\u10000-\u10FFFF]";
            return Regex.Replace(text, re, "");
        }
        static string RemoveUnicode(string text)
        {
            
            var s = Regex.Replace(text, @"[^\u0000-\u007F]+", string.Empty);
            return s;
        }
        static bool IsValidXmlString(string text)
        {
            try
            {
                XmlConvert.VerifyXmlChars(text);
                return true;
            }
            catch
            {
                return false;
            }
        }
            static DataTable GetDataTableFromCsv(string path, bool isFirstRowHeader)
        {
            string header = isFirstRowHeader ? "Yes" : "No";

            string pathOnly = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);

            string sql = @"SELECT * FROM [" + fileName + "]";

            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                      ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
