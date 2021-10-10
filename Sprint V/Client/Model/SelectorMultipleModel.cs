namespace PeliculasCODE5G.Client.Model
{
    public struct SelectorMultipleModel
    {
        public SelectorMultipleModel(string key, string value)
        {
            Key = key;
            Value = value;

        }
        public string Key{get;set;}
        public string Value{get;set;}
        
    }
}