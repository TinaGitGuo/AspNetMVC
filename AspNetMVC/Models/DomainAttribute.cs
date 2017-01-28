using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Models
{
    public class DomainAttribute : ValidationAttribute, IClientValidatable

    {
        public DomainAttribute(int minLength, params string[] propertyNames)
        {
            this.PropertyNames = propertyNames;
            this.MinLength = minLength;
        }

        public string[] PropertyNames { get; private set; }
        public int MinLength { get; private set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            //var properties = this.PropertyNames.Select(validationContext.ObjectType.GetProperty);
            //var values = properties.Select(p => p.GetValue(validationContext.ObjectInstance, null)).OfType<string>();
            //var totalLength = values.Sum(x => x.Length) + Convert.ToString(value).Length;
            //if (totalLength < this.MinLength)
            //{
            //    return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            //}
            //return null;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var modelClientValidationRule = new ModelClientValidationRule
            {
                ValidationType = "requiredif",
                ErrorMessage = ErrorMessage //Added
            };

            modelClientValidationRule.ValidationParameters.Add("param", this.PropertyNames); //Added
            return new List<ModelClientValidationRule> { modelClientValidationRule };

        }

        // public IEnumerable<string> Values { get; private set; }

        // public DomainAttribute(string value)
        // {
        //     this.Values = new string[] { "w" };
        // }

        // //public DomainAttribute(prams string[] values)
        // //{
        // //    this.Values = values;
        // //}

        // protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        // {

        //      return new ValidationResult("error");

        // }


        // public override string FormatErrorMessage(string name)
        //{
        //    string[] values = this.Values.Select(value => string.Format("'{0}'", value)).ToArray();
        //     //return string.Format("{0}{1}", name, string.Join(",", values));
        //     return string.Format(base.ErrorMessageString, name, string.Join(",", values));
        // }
    }
}