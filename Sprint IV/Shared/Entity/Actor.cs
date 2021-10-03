using System;
using System.ComponentModel.DataAnnotations;
namespace PeliculasCODE5G.Shared.Entity
{
    public class Actor
    {
        public int Id{get;set;}
        [Required]
        public string ActorName {get;set;}
        public DocumentType DocumentType {get;set;}
        public string Document {get;set;}
        public Gender Gender {get;set;}
        [Required]
        public DateTime BirthDate{get;set;}
        public int KnowCredits {get;set;}
        public int Nominations {get;set;}
        public string Biography {get;set;}
        public string Photo{get;set;}

    }

    public enum DocumentType{
        CedulaCiudadana = 0,
        CedulaExtranjera = 1,
        Pasaporte = 2,
        RegistroCivil = 3
    }

    public enum Gender{
        Femenino = 0,
        Masculino = 1
    }
}