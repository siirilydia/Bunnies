﻿using System;
using System.Collections.Generic;
using System.Text;

namespace puput
{
    public class Kuviot
    {

        public string peli;

        public char[][,] jaggedArray = new char[10][,]
        {
            new char[,] //pupu0 iloinen
            {
            { ' ', ' ', '_', ' ', ' ', ' ', ' ', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', '\\', ' ', ' ', '/', ' ', '\\', ' ', '.', '.', '.', ' ', '<', '3', ' ', },
            { ' ', '\\', ' ', ' ', '\\', '/', ' ', ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', ' ', '^', ' ', '^', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '#', '_', '_', 'Y', '_', '_', '#', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', '_', '_', ')', '_', '_', '(', '_', '_', ')', '_', '(', '_', '_', '_', '_', ')', }
            },

            new char[,] //pupu1 nukkuva
            {
            { ' ', ' ', '_', ' ', ' ', ' ', ' ', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', '\\', ' ', ' ', '/', ' ', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '\\', ' ', ' ', '\\', '/', ' ', ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', ' ', '_', ' ', '_', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '_', '_', '_', 'Y', '_', '_', '_', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', '_', '_', ')', '_', '_', '(', '_', '_', ')', '_', '(', '_', '_', '_', '_', ')', }
            },

            new char[,] //pupu2
            {
            { ' ', ' ', '_', ' ', ' ', ' ', ' ', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', '\\', ' ', ' ', '/', ' ', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '\\', ' ', ' ', '\\', '/', ' ', ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', ' ', '_', ' ', '.', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '_', '_', '_', 'Y', '_', '_', '_', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', '.', '.', ')', '_', '_', '(', '.', '.', ')', '_', '(', '.', '.', '_', '_', ')', }
            },

            new char[,] //pupu3
            {
            { ' ', ' ', '_', ' ', ' ', ' ', ' ', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', '\\', ' ', ' ', '/', ' ', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '\\', ' ', ' ', '\\', '/', ' ', ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', ' ', '.', ' ', '.', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '_', '_', '_', 'Y', '_', '_', '_', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', '_', '_', ')', '_', '_', '(', '_', '_', ')', '_', '(', '_', '_', '_', '_', ')', }
            },

            new char[,] //pupu4
            {
            { ' ', '_', '_', ' ', ' ', ' ', ' ', '_', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { '/', ' ', ' ', '\\', ' ', ' ', '/', ' ', ' ', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { '\\', '/', '\\', ' ', '\\', '/', ' ', '/', '\\', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', ';', ' ', ' ', ' ', ';', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '_', '´', '_', '^', '_', '`', '_', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', '_', '_', ')', '_', '_', '(', '_', '_', ')', '_', '(', '_', '_', '_', '_', ')', }
            },

            new char[,] //pupu5
            {
            { ' ', '_', '_', ' ', ' ', ' ', ' ', '_', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { '/', ' ', ' ', '\\', ' ', ' ', '/', ' ', ' ', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { '\\', '/', '\\', ' ', '\\', '/', ' ', '/', '\\', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', 'o', ' ', ' ', ' ', 'o', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '_', '´', '_', '^', '_', '`', '_', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', '_', '_', ')', '_', '_', '(', '_', '_', ')', '_', '(', '_', '_', '_', '_', ')', }
            },

            new char[,] //pupu6
            {
            { ' ', ' ', '_', ' ', ' ', ' ', ' ', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', '\\', ' ', ' ', '/', ' ', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '\\', ' ', ' ', '\\', '/', ' ', ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', 'O', ' ', ' ', ' ', 'O', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '_', '´', '_', 'Y', '_', '`', '_', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', '.', '.', '.', ')', '(', '.', '.', '.', ')', '_', '(', '.', '.', '_', '_', ')', }
            },

            new char[,] //pupu7
            {
            { ' ', ' ', '_', ' ', ' ', ' ', ' ', '_', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', '\\', ' ', ' ', '/', ' ', '\\', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '\\', ' ', ' ', '\\', '/', ' ', ' ', '/', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', },
            { ' ', '/', ' ', '\\', ' ', ' ', '/', ' ', '\\', ' ', '_', '_', '_', '_', '{', '*', '}', },
            { '|', ' ', ' ', 'o', ' ', ' ', 'o', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '}', },
            { '\\', '_', '_', '_', '>', '<', '_', '_', '_', '/', ' ', ' ', '_', '(', ' ', ' ', '}', },
            { '(', ',', ',', ',', ')', '(', ',', ',', ',', ')', '_', '(', ',', ',', '_', '_', ')', }
            },

            new char[,] //pupu8
            {
            { ' ', '_', '_', ' ', ' ', ' ', ' ', ' ', ' ', '_', '_', ' '},
            { '/', ' ', ' ', '\\', ' ', ' ', ' ', ' ', '/', ' ', ' ', '\\'},
            { '\\', ' ', ' ', ' ', '\\', ' ', ' ', '/', ' ', ' ', ' ', '/'},
            { ' ', '\\', ' ', ' ', ' ', '\\', '/', ' ', ' ', ' ', '/', ' '},
            { ' ', '/', '¨', '\\', ' ', ' ', ' ', ' ', '/', '¨', '\\', ' '},
            { '|', ' ', ' ', 'O', ' ', ' ', ' ', ' ', 'O', ' ', ' ', '|'},
            { '\\', '_', '*', '_', '_', '>', '<', '_', '_', '*', '_', '/'},
            { '(', ',', ',', ',', ')', ' ', ' ', '(', ',', ',', ',', ')'}
            },

            new char[,] //pupu9
            {
            { ' ', ' ', '_', '_', ' ', ' ', ' ', ' ', ' ', '_', '_', ' ', ' '},
            { ' ', '/', ' ', ' ', '\\', ' ', ' ', ' ', '/', ' ', ' ', '\\', ' '},
            { ' ', '|', ' ', ' ', '|', '_', '_', '_', '|', ' ', ' ', '|', ' '},
            { ' ', '/', ' ', ' ', '\\', ' ', ' ', ' ', '/', ' ', ' ', '\\', ' '},
            { '|', ' ', ' ', 'X', '_', '_', '_', '_', '_', 'X', ' ', ' ', '|'},
            { '|', ' ', '*', '|', 'W', 'W', 'W', 'W', 'W', '|', '*', ' ', '|'},
            { ' ', '\\', ' ', '|', 'M', 'M', 'M', 'M', 'M', '|', ' ', '/', ' '},
            { ' ', '/', ',', ',', ',', '¨', '¨', '¨', ',', ',', ',', '\\', ' '},
            { ' ', '(', ' ', ' ', ' ', ')', ' ', '(', ' ', ' ', ' ', ')', ' '}
            }

        };

        public Kuviot(string peli)
        {
            this.peli = peli;
        }

        public char[,] Pupu0()
        {
            return this.jaggedArray[0];
        }

        public char[,] Pupu1()
        {
            return this.jaggedArray[1];
        }

        public char[,] Pupu2()
        {
            return this.jaggedArray[2];
        }
        public char[,] Pupu3()
        {
            return this.jaggedArray[3];
        }
        public char[,] Pupu4()
        {
            return this.jaggedArray[4];
        }
        public char[,] Pupu5()
        {
            return this.jaggedArray[5];
        }
        public char[,] Pupu6()
        {
            return this.jaggedArray[6];
        }
        public char[,] Pupu7()
        {
            return this.jaggedArray[7];
        }
        public char[,] Pupu8()
        {
            return this.jaggedArray[8];
        }
        public char[,] Pupu9()
        {
            return this.jaggedArray[9];
        }


    }
}
