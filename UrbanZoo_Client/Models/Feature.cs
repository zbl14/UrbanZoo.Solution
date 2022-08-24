using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace UrbanZoo.Models
{
  public class Feature
  {

    public int FeatureId { get; set; }

    public int UserId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool Availability { get; set; } = true;

    public string StreetAddress { get; set; }

    public string State { get; set; }

    public string City { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    public string Zipcode { get; set; }

    public static List<Feature> GetFeatures()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Feature> featureList = JsonConvert.DeserializeObject<List<Feature>>(jsonResponse.ToString());

      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // List<Feature> featureList = JsonConvert.DeserializeObject<List<Feature>>(jsonResponse.ToString());

      return featureList;
    }
    public static Feature GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Feature feature = JsonConvert.DeserializeObject<Feature>(jsonResponse.ToString());

      return feature;
    }

    public static void Post(Feature feature)
    {
      string jsonFeature = JsonConvert.SerializeObject(feature);
      var apiCallTask = ApiHelper.Post(jsonFeature);
    }

    public static void Put(Feature feature)
    {
      string jsonFeature = JsonConvert.SerializeObject(feature);
      var apiCallTask = ApiHelper.Put(feature.FeatureId, jsonFeature);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}