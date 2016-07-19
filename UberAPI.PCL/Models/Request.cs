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
    public class Request : ErrorBase 
    {
        // These fields hold the values for the public properties.
        private object driver;
        private int eta;
        private object location;
        private string requestId;
        private string status;
        private double surgeMultiplier;
        private object vehicle;

        /// <summary>
        /// The object that contains driver details.
        /// </summary>
        [JsonProperty("driver")]
        public object Driver 
        { 
            get 
            {
                return this.driver; 
            } 
            set 
            {
                this.driver = value;
                onPropertyChanged("Driver");
            }
        }

        /// <summary>
        /// The estimated time of vehicle arrival in minutes.
        /// </summary>
        [JsonProperty("eta")]
        public int Eta 
        { 
            get 
            {
                return this.eta; 
            } 
            set 
            {
                this.eta = value;
                onPropertyChanged("Eta");
            }
        }

        /// <summary>
        /// The object that contains the location information of the vehicle and driver
        /// </summary>
        [JsonProperty("location")]
        public object Location 
        { 
            get 
            {
                return this.location; 
            } 
            set 
            {
                this.location = value;
                onPropertyChanged("Location");
            }
        }

        /// <summary>
        /// The unique ID of the Request.
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId 
        { 
            get 
            {
                return this.requestId; 
            } 
            set 
            {
                this.requestId = value;
                onPropertyChanged("RequestId");
            }
        }

        /// <summary>
        /// The status of the Request indicating state.
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The surge pricing multiplier used to calculate the increased price of a Request. A multiplier of 1.0 means surge pricing is not in effect.
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
        /// The object that contains vehicle details.
        /// </summary>
        [JsonProperty("vehicle")]
        public object Vehicle 
        { 
            get 
            {
                return this.vehicle; 
            } 
            set 
            {
                this.vehicle = value;
                onPropertyChanged("Vehicle");
            }
        }
    }
} 