﻿using Newtonsoft.Json;
using QuanLyHopDongVaKySo.SigningWithUsbToken.InstanceData;
using QuanLyHopDongVaKySo.SigningWithUsbToken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHopDongVaKySo.SigningWithUsbToken.Repository
{
    public class TypeOfServiceRepository
    {
        public HttpClient _httpClient;
        public HttpResponseMessage _httpResponseMessage;
        public TypeOfServiceRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7286/");

            //_httpClient.BaseAddress = new Uri("https://techsealapi.azurewebsites.net/");

            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<TypeOfService> GetTypeOfServiceAsync(string id)
        {
            string token = DataStore.Instance.Token;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            _httpResponseMessage = await _httpClient.GetAsync($"api/TypeOfServices/{id}");
            var json = await _httpResponseMessage.Content.ReadAsStringAsync();
            var tos = JsonConvert.DeserializeObject<TypeOfService>(json);
            return tos;
        }
    }
}
