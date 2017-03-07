using System.Collections.Generic;
using System.Runtime.Serialization;

public class Demo
{
    public int Id { get; set; }
    public string Name { get; set; }
}

[DataContract(Namespace = "http://postmancourse.com/ExtendedDemo")]
public class ExtendedDemo
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public List<string> Children { get; set; }
}