﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box.V2
{
    public static class BoxRequestExtensions
    {
        public static T Param<T>(this T request, string name, string value) where T : IBoxRequest
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            request.Parameters[name] = value;

            return request;
        }

        public static T Header<T>(this T request, string name, string value) where T : IBoxRequest
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            request.HttpHeaders.Add(name, value);

            return request;
        }

        public static T Method<T>(this T request, RequestMethod method) where T : IBoxRequest
        {
            request.Method = method;

            return request;
        }

        public static T Payload<T>(this T request, string name, string value) where T : IBoxRequest
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            request.PayloadParameters.Add(name, value);

            return request;
        }

        public static T Authenticate<T>(this T request, string accessToken) where T : IBoxRequest
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException();

            request.HttpHeaders.Add("Authorization", string.Format("Bearer {0}", accessToken));

            return request;
        }
    }
}
