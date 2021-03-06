﻿using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ContosoMoments.Models
{
    public class Image
    {
        string id;
        string imageId;
        string imageFormat;
        string containerName;
        Album album;
        User user;
        string albumId;
        string userId;

        [JsonProperty(PropertyName = "Id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "FileName")]
        public string ImageId
        {
            get { return imageId; }
            set { imageId = value; }
        }

        [JsonProperty(PropertyName = "UploadFormat")]
        public string ImageFormat
        {
            get { return imageFormat; }
            set { imageFormat = value; }
        }

        [JsonProperty(PropertyName = "ContainerName")]
        public string ContainerName
        {
            get { return containerName; }
            set { containerName = value; }
        }

        [JsonProperty(PropertyName = "Album")]
        public Album Album
        {
            get { return album; }
            set { album = value; }
        }

        [JsonProperty(PropertyName = "AlbumId")]
        public string AlbumId
        {
            get { return albumId; }
            set { albumId = value; }
        }

        [JsonProperty(PropertyName = "User")]
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        [JsonProperty(PropertyName = "UserId")]
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        [JsonIgnore]
        public IDictionary<string, Uri> ImagePath
        {
            get
            {
                Dictionary<string, Uri> retVal = new Dictionary<string, Uri>();

                retVal.Add("xs", new Uri(string.Format("{0}/xs/{1}", containerName, imageId)));
                retVal.Add("sm", new Uri(string.Format("{0}/sm/{1}", containerName, imageId)));
                retVal.Add("md", new Uri(string.Format("{0}/md/{1}", containerName, imageId)));
                retVal.Add("lg", new Uri(string.Format("{0}/lg/{1}", containerName, imageId)));

                return retVal;
            }
        }

        [Version]
        public string Version { get; set; }

        [CreatedAt]
        public DateTime CreatedAt { get; set; }

        [UpdatedAt]
        public DateTime UpdatedAt { get; set; }

        [Deleted]
        public bool Deleted { get; set; }
    }
}
