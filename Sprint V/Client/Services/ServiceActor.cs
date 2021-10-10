using System.Security.AccessControl;
using PeliculasCODE5G.Shared.Entity;
using System.Collections.Generic;
using System;

namespace PeliculasCODE5G.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List<Actor>GetActors(){
            return new List<Actor>(){
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Photo="/Images/Actor1.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Photo="/Images/Actor2.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Photo="/Images/Actor3.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="   Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Photo="/Images/Actor4.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Photo="/Images/Actor5.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Photo="/Images/Actor6.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Photo="/Images/Actor7.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="   Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Photo="/Images/Actor1.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Photo="/Images/Actor2.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="   Biografia...."},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Photo="/Images/Actor3.jpg",Document = "12312332",Gender = Gender.Masculino,BirthDate =new DateTime(2020,10,04),KnowCredits=12,Nominations=3,Biography="Biografia...."}
            };
        }
    }
}