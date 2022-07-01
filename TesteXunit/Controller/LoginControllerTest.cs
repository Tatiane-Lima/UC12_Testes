using Chapter.Controllers;
using Chapter.Interfaces;
using Chapter.Models;
using Chapter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXunit.Controller
{
    public class LoginControllerTest
    {
        [Fact]
        public void Retornar_Usuario_Invalido()
        {
            var fakerepository = new Mock<IUsuarioRepository>();
            fakerepository.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);
            LoginVIewModel dadosLogin = new LoginVIewModel();

            dadosLogin.Email = "email@email.com";
            dadosLogin.Senha = "123";

            var controller = new LoginController(fakerepository.Object);

            //Act
            var resultado = controller.Login(dadosLogin);

            //Assert
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }
    }
    }

