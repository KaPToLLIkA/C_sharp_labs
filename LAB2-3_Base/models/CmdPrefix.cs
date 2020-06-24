using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_3_Base.models
{
    public class CmdPrefix
    {
        public const Int32 commandPrefixSize =              4;
        public const string endMessageSeq =                 "#@#";
        public const string setChannelCommandPrefix =       "SETC";
        public const string getCommandPrefix =              "GET_";
        public const string no_CommandPrefix =              "____";

        
        public const string sendMessageCommandPrefix =      "SEND";
        public const string closeConnectionCommandPrefix =  "EXIT";
        public const string msgCommandPrefix =              "MSG_";
        public const string msgListCommandPrefix =          "MSGL";


        public const string registerCommandPrefix =         "REG_";
        public const string registerSuccessCommandPrefix =  "REGS";
        public const string registerErrorCommandPrefix =    "REGE";


        public const string authCommandPrefix =             "AUTH";
        public const string authSuccessCommandPrefix =      "ASUC";
        public const string authErrorCommandPrefix =        "AERR";

    }
}
