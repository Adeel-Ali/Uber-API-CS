/*
 * UberAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/22/2016
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
    public class PriceEstimateCollection : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private List<PriceEsitmate> prices;

        /// <summary>
        /// List of price estimates
        /// </summary>
        [JsonProperty("prices")]
        public List<PriceEsitmate> Prices 
        { 
            get 
            {
                return this.prices; 
            } 
            set 
            {
                this.prices = value;
                onPropertyChanged("Prices");
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