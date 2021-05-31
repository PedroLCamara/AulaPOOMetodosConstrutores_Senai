using System;
using AulaPOOMetodosConstrutores.classes;

namespace AulaPOOMetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            bool respostaCorreta2 = false;
            bool respostaCorreta3 = false;
            string resposta;
            string nome;
            string email;
            string endereco;
            do
            {
                Console.WriteLine(@"Deseja assinar a petição?
                1- Sim
                2- Não");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "1":
                        respostaCorreta = true;
                        do
                        {
                            Console.WriteLine(@"Gostaria de fornecer seu nome ou permanecer em anonimato? 
                        1- Fornecer o nome
                        2- Permanecer em anonimato");
                            resposta = Console.ReadLine();
                            switch (resposta)
                            {
                                case "1":
                                    respostaCorreta2 = true;
                                    Console.WriteLine("Qual é o seu nome?");
                                    nome = Console.ReadLine();
                                    do
                                    {
                                        Console.WriteLine(@"Deseja fornecer otros dados também?
                                1- Sim
                                2- Não");
                                        resposta = Console.ReadLine();
                                        switch (resposta)
                                        {
                                            case "1":
                                                respostaCorreta3= true;
                                                Console.WriteLine("Qual o seu email?");
                                                email = Console.ReadLine();
                                                Console.WriteLine("Qual o seu endereço?");
                                                endereco = Console.ReadLine();
                                                assinante c= new assinante(nome, endereco, email);
                                                Console.WriteLine("Muito obrigado por sua assinatura!");
                                                break;
                                            case "2":
                                                respostaCorreta3 = true;
                                                assinante b= new assinante(nome);
                                                Console.WriteLine("Tudo bem, obrigado por sua assinatura!");
                                                break;
                                            default:
                                                respostaCorreta3= false;
                                                Console.WriteLine("Resposta inválida, diite '1' para fornecer mais dados e '2' para não fornecer mais dados.");
                                                break;
                                        }

                                    } while (respostaCorreta3 == false);
                                    break;
                                case "2":
                                    respostaCorreta2 = true;
                                    Console.WriteLine("Tudo bem, obrigado por sua assinatura!");
                                    assinante a= new assinante();
                                    break;
                                default:
                                    respostaCorreta2= false;
                                    Console.WriteLine("Resposta inválida, digite '1' para fornecer seu nome e '2' para permanecer em anonimato.");
                                    break;
                            }
                        } while (respostaCorreta2 == false);
                        break;
                    case "2":
                        respostaCorreta = true;
                        Console.WriteLine("Tudo bem, obrigado pela atenção!");
                        break;
                    default:
                        respostaCorreta = false;
                        Console.WriteLine("Resposta inválida, digite '1' para assinar a petição e '2' para não assinar.");
                        break;
                }
            } while (respostaCorreta == false);
        }
    }
}
