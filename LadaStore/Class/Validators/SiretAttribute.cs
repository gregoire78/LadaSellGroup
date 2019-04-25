using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadaStore.Class.Validators
{
    public class SiretAttribute : ValidationAttribute
    {
        private int siretMin;
        public SiretAttribute(int AgeMin)
        {
            siretMin = AgeMin;
        }
        public override bool IsValid(object value)
        {
            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(this.ErrorMessage, name, this.siretMin);
        }
    }

}
