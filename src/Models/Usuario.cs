<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisGerenciador.src.Models
{
    public class Usuario : IdentityUser
    {
        [NotMapped]
        public bool IsAdmin { get; set; }

        [Required(ErrorMessage = "Nome do usuario é obrigatorio.")]
        [MinLength(6, ErrorMessage = "Nome inválido")]
        public string Nome { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisGerenciador.src.Models
{
    public class Usuario : IdentityUser
    {
        [NotMapped]
        public bool IsAdmin { get; set; }

        [Required(ErrorMessage = "Nome do usuario é obrigatorio.")]
        [MinLength(6, ErrorMessage = "Nome inválido")]
        public string Nome { get; set; }
    }
}
>>>>>>> f76de441cf2f142de929dd6691654639c359cc9b
