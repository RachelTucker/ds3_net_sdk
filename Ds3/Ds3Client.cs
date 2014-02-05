﻿using System;

using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

using Ds3.Runtime;
using Ds3.Models;


namespace Ds3
{
    public class Ds3Client
    {
        private Credentials Creds;
        private Uri Endpoint;        

        public Ds3Client(string endpoint, Credentials creds) {
            this.Creds = creds;
            this.Endpoint = new Uri(endpoint);            
        }
        
        public GetServiceResponse GetService(GetServiceRequest request){
            Task<GetServiceResponse> response = GetServiceAsync(request);

            return response.Result;
        }

        public Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request)
        {
            return Network.Invoke<GetServiceResponse, GetServiceRequest>(request, this.Endpoint, this.Creds);            
        }       
    }
}