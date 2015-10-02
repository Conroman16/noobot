﻿using System;
using System.Collections.Generic;
using Noobot.Domain.MessagingPipeline.Request;
using Noobot.Domain.MessagingPipeline.Response;

namespace Noobot.Domain.MessagingPipeline.Middleware.StandardMiddleware
{
    public class HandlerMapping
    {
        public string[] ValidHandles { get; set; }
        public string Description { get; set; }
        public Func<IncomingMessage, IEnumerable<ResponseMessage>> EvaluatorFunc { get; set; }
        public bool ShouldContinueProcessing { get; set; }
    }
}