using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class CaesarCipher
    {
        public static void EncryptMessage(string message, int decalage)
        {
            char[] alphabet = {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            int sizeMessage = message.Length;
            char[] convertMessage = new char[sizeMessage];

            //il faut prendre le message lettre par lettre, puis décaler les lettres en fonction du décalage demander
            //Si la lettre est 'e' la décaler de 3 est donne 'h'
            //Il faut parcourir le message, recuperer le caracter est le décaler de 3 exemple 'a' devient 'd'. Si 'z' revenir à zero 'c'.
            //L'aphabet est de 24 caractére. Et penser à gere les espace qui reste des espaces

            for (int i = 0; i < sizeMessage; i++)
            {
                //On parcourt le message lettre par lettre 
                //On chercher la lettre correspondant dans le tableau, si match on recuper l'index
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (message[i] == alphabet[j])
                    {
                        //Attention si 'z' revenir au debut de l'aphabet. Si arriver à l'index 23, revenir au debut du tableau
                        //Attention decaler vers la gauche inverser la problematique
                        if (j + decalage-1 > 23)
                        {
                            convertMessage[i] = alphabet[decalage-1];
                        }
                        else
                        {
                            convertMessage[i] = alphabet[j + decalage];
                        }
                    }
                    else if (message[i] == ' ')
                    {
                        convertMessage[i] = ' ';
                    }
                    else if (message[i] == ',')
                    {
                        convertMessage[i] = ',';
                    }
                }
            }
            Console.WriteLine($"Le message devient : {new String(convertMessage)}");
        }
    }
}
