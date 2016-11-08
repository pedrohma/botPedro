using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace botPedro.Model
{
    [LuisModel("e3866536-b821-462f-b2ce-f6913f97e8dc", "d62c7688831a4ab0871f3e3cb0e71e15")]
    [Serializable]
    public class RootLuisDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        public async Task NoneAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Desculpe, eu não entendi...");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Saudacao")]
        public async Task OiAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Olá, tudo bem?");


            context.Wait(MessageReceived);
        }

        [LuisIntent("Ajuda")]
        public async Task AjudaAsync(IDialogContext context, LuisResult result)
        {

            await context.PostAsync("Como poderia lhe ajudar? \n\n 1.Agendar \n\n 2.Consultar");
            context.Wait(MessageReceived);
        }
      

    }
}