
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrbanZoo.Models;

namespace UrbanZoo.Controllers
{
  public class FeaturesController : Controller
  {
    public IActionResult Index()
    {
      var allFeatures = Feature.GetFeatures();
      return View(allFeatures);
    }

    [HttpPost]
    public IActionResult Index(Feature feature)
    {
      Feature.Post(feature);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var feature = Feature.GetDetails(id);
      return View(feature);
    }

    public IActionResult Edit(int id)
    {
      var feature = Feature.GetDetails(id);
      return View(feature);
    }

    [HttpPost]
    public IActionResult Details(int id, Feature feature)
    {
      feature.FeatureId = id;
      Feature.Put(feature);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Feature.Delete(id);
      return RedirectToAction("Index");
    }
  }}
