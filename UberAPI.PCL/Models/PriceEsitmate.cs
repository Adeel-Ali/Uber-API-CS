/*
 * UberAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 07/19/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using UberAPI.PCL;

namespace UberAPI.PCL.Models
{
    public class PriceEsitmate : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string currencyCode;
        private string displayName;
        private double distance;
        private int duration;
        private string estimate;
        private int highEstimate;
        private int lowEstimate;
        private string productId;
        private double surgeMultiplier;

        /// <summary>
        /// ISO 4217 currency code.
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// Display name of product.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName 
        { 
            get 
            {
                return this.displayName; 
            } 
            set 
            {
                this.displayName = value;
                onPropertyChanged("DisplayName");
            }
        }

        /// <summary>
        /// Expected activity distance (in miles).
        /// </summary>
        [JsonProperty("distance")]
        public double Distance 
        { 
            get 
            {
                return this.distance; 
            } 
            set 
            {
                this.distance = value;
                onPropertyChanged("Distance");
            }
        }

        /// <summary>
        /// Expected activity duration (in seconds). Always show duration in minutes.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration 
        { 
            get 
            {
                return this.duration; 
            } 
            set 
            {
                this.duration = value;
                onPropertyChanged("Duration");
            }
        }

        /// <summary>
        /// Formatted string of estimate in local currency of the start location. Estimate could be a range, a single number (flat rate) or "Metered" for TAXI.
        /// </summary>
        [JsonProperty("estimate")]
        public string Estimate 
        { 
            get 
            {
                return this.estimate; 
            } 
            set 
            {
                this.estimate = value;
                onPropertyChanged("Estimate");
            }
        }

        /// <summary>
        /// Upper bound of the estimated price.
        /// </summary>
        [JsonProperty("high_estimate")]
        public int HighEstimate 
        { 
            get 
            {
                return this.highEstimate; 
            } 
            set 
            {
                this.highEstimate = value;
                onPropertyChanged("HighEstimate");
            }
        }

        /// <summary>
        /// Lower bound of the estimated price.
        /// </summary>
        [JsonProperty("low_estimate")]
        public int LowEstimate 
        { 
            get 
            {
                return this.lowEstimate; 
            } 
            set 
            {
                this.lowEstimate = value;
                onPropertyChanged("LowEstimate");
            }
        }

        /// <summary>
        /// Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId 
        { 
            get 
            {
                return this.productId; 
            } 
            set 
            {
                this.productId = value;
                onPropertyChanged("ProductId");
            }
        }

        /// <summary>
        /// Expected surge multiplier. Surge is active if surge_multiplier is greater than 1. Price estimate already factors in the surge multiplier.
        /// </summary>
        [JsonProperty("surge_multiplier")]
        public double SurgeMultiplier 
        { 
            get 
            {
                return this.surgeMultiplier; 
            } 
            set 
            {
                this.surgeMultiplier = value;
                onPropertyChanged("SurgeMultiplier");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 