﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.UPCNETSystemWebService;
using UPCNETSystemCliente.Business_Entities;

namespace UPCNETSystemCliente.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
           // UPCNETServiceClient proxy = new UPCNETServiceClient();
           // UPCNETSystemWebService.alumno[] listaAlumnos = proxy.Enviar_Alumnos();
            return View();
        }

        public ActionResult Alumnos()
        {
            // Reemplazar por la lista de Base de Datos
            // Debo pedir permiso para implementar un template
            List<Alumno> listaAlumnos = new List<Alumno>();
            listaAlumnos.Add(new Alumno("Ian", "Maguiña", "666", "Ing. de Bica", "666", "La bica.com", "Fecha", "00"));
            listaAlumnos.Add(new Alumno("Victor", "Weaver", "777", "Ing. de Ian", "999", "asd.com", "Fecha 2", "01"));
            listaAlumnos.Add(new Alumno("Ulices", "NoConS", "888", "Ing. de Ian", "990", "asds.com", "Fecha 3", "03"));
            listaAlumnos.Add(new Alumno("Peppi", "Alex", "787", "Ing. de Ian", "299", "as2.com", "Fecha 4", "02"));
            return View(listaAlumnos);
        }

    }
}
