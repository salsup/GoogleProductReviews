using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Models
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class feed
    {

        private feedAggregator aggregatorField;

        private feedPublisher publisherField;

        private feedReview[] reviewsField;

        private feedDeleted_reviews deleted_reviewsField;

        /// <remarks/>
        public feedAggregator aggregator
        {
            get
            {
                return this.aggregatorField;
            }
            set
            {
                this.aggregatorField = value;
            }
        }

        /// <remarks/>
        public feedPublisher publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("review", IsNullable = false)]
        public feedReview[] reviews
        {
            get
            {
                return this.reviewsField;
            }
            set
            {
                this.reviewsField = value;
            }
        }

        /// <remarks/>
        public feedDeleted_reviews deleted_reviews
        {
            get
            {
                return this.deleted_reviewsField;
            }
            set
            {
                this.deleted_reviewsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedAggregator
    {

        private string nameField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedPublisher
    {

        private string nameField;

        private string faviconField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string favicon
        {
            get
            {
                return this.faviconField;
            }
            set
            {
                this.faviconField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReview
    {

        private ushort review_idField;

        private bool review_idFieldSpecified;

        private feedReviewReviewer reviewerField;

        private System.DateTime review_timestampField;

        private string titleField;

        private string contentField;

        private string[] prosField;

        private feedReviewCons consField;

        private feedReviewReview_url review_urlField;

        private feedReviewRatings ratingsField;

        private feedReviewProducts productsField;

        private bool is_spamField;

        private bool is_spamFieldSpecified;

        private string collection_methodField;

        private string transaction_idField;

        /// <remarks/>
        public ushort review_id
        {
            get
            {
                return this.review_idField;
            }
            set
            {
                this.review_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool review_idSpecified
        {
            get
            {
                return this.review_idFieldSpecified;
            }
            set
            {
                this.review_idFieldSpecified = value;
            }
        }

        /// <remarks/>
        public feedReviewReviewer reviewer
        {
            get
            {
                return this.reviewerField;
            }
            set
            {
                this.reviewerField = value;
            }
        }

        /// <remarks/>
        public System.DateTime review_timestamp
        {
            get
            {
                return this.review_timestampField;
            }
            set
            {
                this.review_timestampField = value;
            }
        }

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("pro", IsNullable = false)]
        public string[] pros
        {
            get
            {
                return this.prosField;
            }
            set
            {
                this.prosField = value;
            }
        }

        /// <remarks/>
        public feedReviewCons cons
        {
            get
            {
                return this.consField;
            }
            set
            {
                this.consField = value;
            }
        }

        /// <remarks/>
        public feedReviewReview_url review_url
        {
            get
            {
                return this.review_urlField;
            }
            set
            {
                this.review_urlField = value;
            }
        }

        /// <remarks/>
        public feedReviewRatings ratings
        {
            get
            {
                return this.ratingsField;
            }
            set
            {
                this.ratingsField = value;
            }
        }

        /// <remarks/>
        public feedReviewProducts products
        {
            get
            {
                return this.productsField;
            }
            set
            {
                this.productsField = value;
            }
        }

        /// <remarks/>
        public bool is_spam
        {
            get
            {
                return this.is_spamField;
            }
            set
            {
                this.is_spamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is_spamSpecified
        {
            get
            {
                return this.is_spamFieldSpecified;
            }
            set
            {
                this.is_spamFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string collection_method
        {
            get
            {
                return this.collection_methodField;
            }
            set
            {
                this.collection_methodField = value;
            }
        }

        /// <remarks/>
        public string transaction_id
        {
            get
            {
                return this.transaction_idField;
            }
            set
            {
                this.transaction_idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewReviewer
    {

        private feedReviewReviewerName nameField;

        private uint reviewer_idField;

        private bool reviewer_idFieldSpecified;

        /// <remarks/>
        public feedReviewReviewerName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public uint reviewer_id
        {
            get
            {
                return this.reviewer_idField;
            }
            set
            {
                this.reviewer_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reviewer_idSpecified
        {
            get
            {
                return this.reviewer_idFieldSpecified;
            }
            set
            {
                this.reviewer_idFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewReviewerName
    {

        private bool is_anonymousField;

        private bool is_anonymousFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool is_anonymous
        {
            get
            {
                return this.is_anonymousField;
            }
            set
            {
                this.is_anonymousField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is_anonymousSpecified
        {
            get
            {
                return this.is_anonymousFieldSpecified;
            }
            set
            {
                this.is_anonymousFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewCons
    {

        private string conField;

        /// <remarks/>
        public string con
        {
            get
            {
                return this.conField;
            }
            set
            {
                this.conField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewReview_url
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewRatings
    {

        private feedReviewRatingsOverall overallField;

        /// <remarks/>
        public feedReviewRatingsOverall overall
        {
            get
            {
                return this.overallField;
            }
            set
            {
                this.overallField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewRatingsOverall
    {

        private byte minField;

        private byte maxField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewProducts
    {

        private feedReviewProductsProduct productField;

        /// <remarks/>
        public feedReviewProductsProduct product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewProductsProduct
    {

        private feedReviewProductsProductProduct_ids product_idsField;

        private string product_nameField;

        private string product_urlField;

        /// <remarks/>
        public feedReviewProductsProductProduct_ids product_ids
        {
            get
            {
                return this.product_idsField;
            }
            set
            {
                this.product_idsField = value;
            }
        }

        /// <remarks/>
        public string product_name
        {
            get
            {
                return this.product_nameField;
            }
            set
            {
                this.product_nameField = value;
            }
        }

        /// <remarks/>
        public string product_url
        {
            get
            {
                return this.product_urlField;
            }
            set
            {
                this.product_urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewProductsProductProduct_ids
    {

        private feedReviewProductsProductProduct_idsGtins gtinsField;

        private feedReviewProductsProductProduct_idsMpns mpnsField;

        private feedReviewProductsProductProduct_idsSkus skusField;

        private feedReviewProductsProductProduct_idsBrands brandsField;

        /// <remarks/>
        public feedReviewProductsProductProduct_idsGtins gtins
        {
            get
            {
                return this.gtinsField;
            }
            set
            {
                this.gtinsField = value;
            }
        }

        /// <remarks/>
        public feedReviewProductsProductProduct_idsMpns mpns
        {
            get
            {
                return this.mpnsField;
            }
            set
            {
                this.mpnsField = value;
            }
        }

        /// <remarks/>
        public feedReviewProductsProductProduct_idsSkus skus
        {
            get
            {
                return this.skusField;
            }
            set
            {
                this.skusField = value;
            }
        }

        /// <remarks/>
        public feedReviewProductsProductProduct_idsBrands brands
        {
            get
            {
                return this.brandsField;
            }
            set
            {
                this.brandsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewProductsProductProduct_idsGtins
    {

        private ulong gtinField;

        /// <remarks/>
        public ulong gtin
        {
            get
            {
                return this.gtinField;
            }
            set
            {
                this.gtinField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewProductsProductProduct_idsMpns
    {

        private string mpnField;

        /// <remarks/>
        public string mpn
        {
            get
            {
                return this.mpnField;
            }
            set
            {
                this.mpnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewProductsProductProduct_idsSkus
    {

        private string skuField;

        /// <remarks/>
        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedReviewProductsProductProduct_idsBrands
    {

        private string brandField;

        /// <remarks/>
        public string brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class feedDeleted_reviews
    {

        private ushort review_idField;

        /// <remarks/>
        public ushort review_id
        {
            get
            {
                return this.review_idField;
            }
            set
            {
                this.review_idField = value;
            }
        }
    }


}
