using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MessageBird.Objects.Conversations
{
    public class InteractiveContent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("body")]
        public Body Body { get; set; }

        [JsonProperty("action")]
        public Action Action { get; set; }

        [JsonProperty("reply")]
        public Reply Reply { get; set; }
    }
    public class Reply
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
    public class Header
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Body
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Button
    {
        public Button(string title)
        {
            Id = Guid.NewGuid().ToString();
            Type = "reply";
            Title = title;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Row
    {
        public Row(string title)
        {
                Id = Guid.NewGuid().ToString();
                Title = title;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Section
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rows")]
        public List<Row> Rows { get; set; }
    }

    public class Action
    {
        [JsonProperty("buttons")]
        public IList<Button> Buttons { get; set; }

        [JsonProperty("button")]
        public string Button { get; set; }

        [JsonProperty("sections")]
        public List<Section> Sections { get; set; }
    }
}