using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Matrices.Controllers
{
    public class MatricesController : Controller
    {
        public IActionResult Index(int lado)
        {
            return View();
        }

        [Route("/random/{lado}")]
        public IActionResult random (int lado)
        {
            ViewBag.lado = lado;

            int[,] matriz = new int[lado, lado];
            ViewBag.matriz = matriz;

            Random random = new Random();
            for (int i = 0; i < ViewBag.lado; i++)
            {
                for (int j = 0; j < ViewBag.lado; j++)
                {
                    int randomNumber = random.Next(0, lado+1);

                    matriz[i, j] = randomNumber;
                }
            }
            return View("Global");
        }

        [Route("/diagonal/{lado}")]
        public IActionResult diagonal (int lado)
        {
            ViewBag.lado = lado;
            int numero = 0;

            int[,] matriz = new int[lado, lado];
            ViewBag.matriz = matriz;

   
            for (int i = 0; i < ViewBag.lado; i++)
            {
                numero = i+1;
                bool controlarDiagonal = false; 

                for (int j = 0; j < ViewBag.lado; j++)
                {
                    matriz[i, j] = numero;

                    if (numero > 1 && !controlarDiagonal)
                    {
                        numero--;

                        if (numero+1 == 1)
                        {
                            controlarDiagonal = true;
                        }
                    }
                    else
                    {
                        numero++;
                        controlarDiagonal = true;
                    }
                }
            }
            return View("Global");
        }

        [Route("/diamante/{lado}")]
        public IActionResult diamante (int lado)
        {
            ViewBag.lado = lado;
            int numero = 1;
            double pasadasBucle; 

            int[,] matriz = new int[lado, lado];
            ViewBag.matriz = matriz;

            pasadasBucle = lado/2.0;
            pasadasBucle = Math.Ceiling(pasadasBucle);

            for (int i = 0; i < pasadasBucle; i++)
            {     
                for (int j = 0; j < pasadasBucle; j++)
                {
                    matriz[i, j] = numero;
                    matriz[i, lado - j] = numero;
                    matriz[lado - i, j] = numero;
                    matriz[lado - i, lado - j] = numero;
                }
                numero++; 
            }
            return View("Global");
        }
    }
}