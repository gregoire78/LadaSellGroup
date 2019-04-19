﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadaStore.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Nom", Prompt = "votre nom")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public string Name { get; set; }

        [Display(Name = "Prénom", Prompt = "votre prénom")]
        [Required(ErrorMessage = "{0} obligatoire")]
        public string Firstname { get; set; }

        [Display(Name = "Adresse email", Prompt = "exemple@exemple.com")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} obligatoire")]
        [EmailAddress(ErrorMessage = "{0} n'est pas au bon format.")]
        public string Email { get; set; }

        [Display(Name = "Mot de passe", Prompt = "password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} obligatoire")]
        //[RegularExpression("expression", ErrorMessage = "")]
        [StringLength(18, MinimumLength = 6, ErrorMessage = "{0} doit contenir entre {2} et {1} caractères.")]
        public string Password { get; set; }

        [Display(Name = "Confirmation mot de passe", Prompt = "password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "{0} n'est identique à {1}.")]
        public string ConfirmedPassword { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "{0} obligatoire")]
        [DataType(DataType.Text)]
        public String Address { get; set; }

        [Display(Name="Siret")]
        [DataType(DataType.Text)]
        public string Siret { get; set; }

    }
}
