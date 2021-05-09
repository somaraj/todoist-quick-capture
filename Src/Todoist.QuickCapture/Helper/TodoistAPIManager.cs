using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using Todoist.QuickCapture.DTO;

namespace Todoist.QuickCapture.Helper
{
    public class TodoistAPIManager
    {
        private readonly RestClient Client;
        private readonly string BaseURL = "https://api.todoist.com/rest/v1/";
        private readonly string AuthToken = "199c2fbba7b08b38a874ce4581972ad75fe3f4df";

        public TodoistAPIManager()
        {
            Client = new RestClient(BaseURL);
        }

        public List<ProjectDTO> GetAllProjects()
        {
            var data = new List<ProjectDTO>();
            try
            {
                var request = new RestRequest("projects", DataFormat.Json);
                request.AddHeader("authorization", $"Bearer {AuthToken}");
                var response = Client.Get(request);

                if (!string.IsNullOrEmpty(response.Content))
                    data = JsonConvert.DeserializeObject<List<ProjectDTO>>(response.Content);
            }
            catch (Exception ex)
            {

            }

            return data;
        }

        public List<TaskDTO> GetAllTasks()
        {
            var data = new List<TaskDTO>();
            try
            {
                var request = new RestRequest("tasks", DataFormat.Json);
                request.AddHeader("authorization", $"Bearer {AuthToken}");
                var response = Client.Get(request);

                if (!string.IsNullOrEmpty(response.Content))
                    data = JsonConvert.DeserializeObject<List<TaskDTO>>(response.Content);
            }
            catch (Exception ex)
            {

            }

            return data;
        }

        public List<LabelDTO> GetAllLabels()
        {
            var data = new List<LabelDTO>();
            try
            {
                var request = new RestRequest("labels", DataFormat.Json);
                request.AddHeader("authorization", $"Bearer {AuthToken}");
                var response = Client.Get(request);

                if (!string.IsNullOrEmpty(response.Content))
                    data = JsonConvert.DeserializeObject<List<LabelDTO>>(response.Content);
            }
            catch (Exception ex)
            {

            }

            return data;
        }

        public List<PriorityDTO> GetAllPriorities()
        {
            var data = new List<PriorityDTO> {
                new PriorityDTO { Id = 1, Name = "P1" },
                new PriorityDTO { Id = 2, Name = "P2" },
                new PriorityDTO { Id = 3, Name = "P3" },
                new PriorityDTO { Id = 4, Name = "P4" }
            };

            return data;
        }

        public TaskDTO CreateTask(NewTaskDTO task)
        {
            var data = new TaskDTO();
            try
            {
                var request = new RestRequest("tasks", DataFormat.Json);
                request.AddHeader("X-Request-Id", Guid.NewGuid().ToString("N"));
                request.AddHeader("authorization", $"Bearer {AuthToken}");
                request.AddJsonBody(JsonConvert.SerializeObject(task));
                var response = Client.Post(request);

                if (!string.IsNullOrEmpty(response.Content))
                    data = JsonConvert.DeserializeObject<TaskDTO>(response.Content);
            }
            catch (Exception ex)
            {

            }

            return data;
        }
    }
}
