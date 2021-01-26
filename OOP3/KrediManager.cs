using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
   interface IKrediManager
    {
        // interface ler bırbırnın alternatifi olan fakat
        //kod ıcerıklerı farklı olan durumlar için kullanılır
        //bu ornekte kredi türlerinin hepsınde hesapla vardır.hepsinde ortaktır
        //ama kodları farklıdır.faiz oranları vs..

        void Hesapla();
        void BiseyYap();
        
    }
}
