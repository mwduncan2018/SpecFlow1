﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowBdd.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Fuzzy matching", new string[] {
            "fuzzyMatching"}, Description="\tFuzzy matching indicates a match if either manufacturer or model match.", SourceFile="Features\\FuzzyMatching.feature", SourceLine=1)]
    public partial class FuzzyMatchingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "fuzzyMatching"};
        
#line 1 "FuzzyMatching.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Fuzzy matching", "\tFuzzy matching indicates a match if either manufacturer or model match.", ProgrammingLanguage.CSharp, new string[] {
                        "fuzzyMatching"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void ManufacturerMatchModelMatch(string productManufacturer, string productModel, string entryManufacturer, string entryModel, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("productManufacturer", productManufacturer);
            argumentsOfScenario.Add("productModel", productModel);
            argumentsOfScenario.Add("entryManufacturer", entryManufacturer);
            argumentsOfScenario.Add("entryModel", entryModel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manufacturer match, model match", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("a product is added with manufacturer {0} and model {1}", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And(string.Format("an entry is added with manufacturer {0} and model {1}", entryManufacturer, entryModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.When("fuzzy matching is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then(string.Format("the product with manufacturer {0} and model {1}  is a standard match", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer match, model match, Variant 0", SourceLine=12)]
        public virtual void ManufacturerMatchModelMatch_Variant0()
        {
#line 5
this.ManufacturerMatchModelMatch("Wendy\'s", "Taco Salad", "Wendy\'s", "Taco Salad", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer match, model match, Variant 1", SourceLine=12)]
        public virtual void ManufacturerMatchModelMatch_Variant1()
        {
#line 5
this.ManufacturerMatchModelMatch("Wendy\'s", "Apple Pecan Salad", "Wendy\'s", "Apple Pecan Salad", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer match, model match, Variant 2", SourceLine=12)]
        public virtual void ManufacturerMatchModelMatch_Variant2()
        {
#line 5
this.ManufacturerMatchModelMatch("Wendy\'s", "Jalapeno Popper Salad", "Wendy\'s", "Jalapeno Popper Salad", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer match, model match, Variant 3", SourceLine=12)]
        public virtual void ManufacturerMatchModelMatch_Variant3()
        {
#line 5
this.ManufacturerMatchModelMatch("Wendy\'s", "Bourbon Bacon Cheeseburger", "Wendy\'s", "Bourbon Bacon Cheeseburger", ((string[])(null)));
#line hidden
        }
        
        public virtual void ManufacturerNoMatchModelNoMatch(string productManufacturer, string productModel, string entryManufacturer, string entryModel, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("productManufacturer", productManufacturer);
            argumentsOfScenario.Add("productModel", productModel);
            argumentsOfScenario.Add("entryManufacturer", entryManufacturer);
            argumentsOfScenario.Add("entryModel", entryModel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manufacturer no match, model no match", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given(string.Format("a product is added with manufacturer {0} and model {1}", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.And(string.Format("an entry is added with manufacturer {0} and model {1}", entryManufacturer, entryModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.When("fuzzy matching is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then(string.Format("the product with manufacturer {0} and model {1} is not a match", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer no match, model no match, Variant 0", SourceLine=26)]
        public virtual void ManufacturerNoMatchModelNoMatch_Variant0()
        {
#line 19
this.ManufacturerNoMatchModelNoMatch("Taco Bell", "Grilled Cheese Burrito", "Burger King", "Impossible Whopper", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer no match, model no match, Variant 1", SourceLine=26)]
        public virtual void ManufacturerNoMatchModelNoMatch_Variant1()
        {
#line 19
this.ManufacturerNoMatchModelNoMatch("Taco Bell", "Veggie Burrito Supreme", "Burger King", "Texas Double Whopper", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer no match, model no match, Variant 2", SourceLine=26)]
        public virtual void ManufacturerNoMatchModelNoMatch_Variant2()
        {
#line 19
this.ManufacturerNoMatchModelNoMatch("Taco Bell", "Quesarito", "Burger King", "Bacon King", ((string[])(null)));
#line hidden
        }
        
        public virtual void ManufacturerMatchModelNoMatch(string productManufacturer, string productModel, string entryManufacturer, string entryModel, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("productManufacturer", productManufacturer);
            argumentsOfScenario.Add("productModel", productModel);
            argumentsOfScenario.Add("entryManufacturer", entryManufacturer);
            argumentsOfScenario.Add("entryModel", entryModel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manufacturer match, model no match", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 32
 testRunner.Given(string.Format("a product is added with manufacturer {0} and model {1}", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 33
 testRunner.And(string.Format("an entry is added with manufacturer {0} and model {1}", entryManufacturer, entryModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.When("fuzzy matching is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then(string.Format("the product with manufacturer {0} and model {1} is a fuzzy match", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer match, model no match, Variant 0", SourceLine=38)]
        public virtual void ManufacturerMatchModelNoMatch_Variant0()
        {
#line 31
this.ManufacturerMatchModelNoMatch("Burger King", "Italian Original Chicken", "Burger King", "Four nuggets", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer match, model no match, Variant 1", SourceLine=38)]
        public virtual void ManufacturerMatchModelNoMatch_Variant1()
        {
#line 31
this.ManufacturerMatchModelNoMatch("Burger King", "Spicy Chicken Sandwich", "Burger King", "Chicken Deluxe Sandwich", ((string[])(null)));
#line hidden
        }
        
        public virtual void ManufacturerNoMatchModelMatch(string productManufacturer, string productModel, string entryManufacturer, string entryModel, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("productManufacturer", productManufacturer);
            argumentsOfScenario.Add("productModel", productModel);
            argumentsOfScenario.Add("entryManufacturer", entryManufacturer);
            argumentsOfScenario.Add("entryModel", entryModel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manufacturer no match, model match", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 43
 testRunner.Given(string.Format("a product is added with manufacturer {0} and model {1}", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
 testRunner.And(string.Format("an entry is added with manufacturer {0} and model {1}", entryManufacturer, entryModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.When("fuzzy matching is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then(string.Format("the product with manufacturer {0} and model {1}  is a fuzzy match", productManufacturer, productModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer no match, model match, Popeyes", SourceLine=49)]
        public virtual void ManufacturerNoMatchModelMatch_Popeyes()
        {
#line 42
this.ManufacturerNoMatchModelMatch("Popeyes", "Chicken Sandwich", "Burger King", "Chicken Sandwich", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manufacturer no match, model match, McDonald\'s", SourceLine=49)]
        public virtual void ManufacturerNoMatchModelMatch_McDonalds()
        {
#line 42
this.ManufacturerNoMatchModelMatch("McDonald\'s", "Hamburger", "Sonic", "Hamburger", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
