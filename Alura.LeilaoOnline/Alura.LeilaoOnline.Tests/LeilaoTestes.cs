﻿using Alura.LeilaoOnline.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoTestes
    {
        [Fact]
        public void LeilaoComVariosLances()
        {
            //Arrange
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);
            int maiorLance = 1000;

            leilao.RecebeLance(maria, 700);
            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, maiorLance);
            leilao.RecebeLance(fulano, 900);

            //Act - método sendo testado
            leilao.TerminaPregao();

            var valorObtido = leilao.Ganhador.Valor;
            var valorEsperado = maiorLance;

            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        public void LeilaoComUmLance()
        {
            //Arrange
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            int maiorLance = 800;
   
            leilao.RecebeLance(fulano, maiorLance);

            //Act - método sendo testado
            leilao.TerminaPregao();

            var valorObtido = leilao.Ganhador.Valor;
            var valorEsperado = maiorLance;

            //Assert
            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}
