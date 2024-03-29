﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using AspireBank.Model;
using System.Text;
using System.Threading.Tasks;

namespace AspireBank.Service
{
        public class DataServiceCorrentista : DataService
        {
            public static async Task<Correntista> Cadastrar(Correntista c)
            {
                var json_a_enviar = JsonConvert.SerializeObject(c);

                string json = await DataService.PostDataToService(json_a_enviar, "/correntista/save");

                Console.WriteLine("_____________________________________________");
                Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
                Console.WriteLine(json_a_enviar);
                Console.WriteLine("_____________________________________________");


                Correntista correntista = JsonConvert.DeserializeObject<Correntista>(json);

                return correntista;
            }

        public static async Task<Correntista> Autorizar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/entrar");

            //Console.WriteLine("_____________________________________________");
            //Console.WriteLine(json);
            //Console.WriteLine("_____________________________________________");

            Correntista correntista = new Correntista();
            if (json != "false")
            {
                correntista = JsonConvert.DeserializeObject<Correntista>(json);
            }
            Console.WriteLine(json);


            return correntista;

        }
    }
    
}
