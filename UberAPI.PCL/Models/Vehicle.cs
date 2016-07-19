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
    public class Vehicle : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string licensePlate;
        private string make;
        private string model;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("license_plate")]
        public string LicensePlate 
        { 
            get 
            {
                return this.licensePlate; 
            } 
            set 
            {
                this.licensePlate = value;
                onPropertyChanged("LicensePlate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("make")]
        public string Make 
        { 
            get 
            {
                return this.make; 
            } 
            set 
            {
                this.make = value;
                onPropertyChanged("Make");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("model")]
        public string Model 
        { 
            get 
            {
                return this.model; 
            } 
            set 
            {
                this.model = value;
                onPropertyChanged("Model");
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