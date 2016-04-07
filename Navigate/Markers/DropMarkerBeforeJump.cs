using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AllCodeRush.Navigate.Markers
{
  public static class Resource
  {
    /// <summary>
    /// Gets the specified embedded resource as a text file, returning it as a string.
    /// </summary>
    /// <param name="resourceName">The name of the resource file to read. The default 
    /// namespace will be prepended by this method automatically. If this file is inside a 
    /// folder, specify that folder name (replace spaces with the underscore character) 
    /// as part of the resource name. Folder names should be delimited by a dot (e.g., 
    /// "XML.DropMarkerBeforeJump.xml").</param>
    public static string Get(string resourceName)
    {
      var assembly = Assembly.GetExecutingAssembly();

      using (Stream stream = assembly.GetManifestResourceStream("CodeRushSetup." + resourceName))
      using (StreamReader reader = new StreamReader(stream))
        return reader.ReadToEnd();
    }
  }

  public class SetupOption
  {
    public string Title { get; set; }
    public string Image { get; set; }
    public string Hint { get; set; }
    public string Description { get; set; }
  }

  class Script
  {
    private List<SetupOption> setupOptions = new List<SetupOption>();
    static XmlSerializer xmlSerializer;

    public Script()
    {
    }

    public static System.Type[] GetKnownTypes()
    {
      System.Type[] knownTypes = new System.Type[2];
      knownTypes[0] = typeof(SetupOption);
      knownTypes[1] = typeof(Script);
      return knownTypes;
    }

    public static XmlSerializer Store
    {
      get
      {
        // Make code changes...
        if (xmlSerializer == null)
          xmlSerializer = new XmlSerializer(typeof(Script), GetKnownTypes());
        return xmlSerializer;
      }
    }
    public static Script Load(string fileName)
    {
      string xmlTxt = Resource.Get("XML." + fileName);
      xmlTxt = Resource.Get("XML." + fileName);
      Script setupScript;
      using (TextReader r = new StringReader(xmlTxt))
        try
        {
          setupScript = (Script)Store.Deserialize(r);
        }
        catch (Exception ex)
        {
          throw new Exception("Error deserializing.", ex);
        }
      return setupScript;
    }

    /// <summary>
    /// Serializes this instance to the specified file.
    /// </summary>
    /// <param name="savePath">The file path to save to.</param>
    public void Save(string savePath)
    {
      FileStream file = File.Create(savePath);
      Store.Serialize(file, this);
      file.Close();
    }

    /// <summary>
    /// Serializes this instance to a string and returns that string.
    /// </summary>
    /// <returns>A XML representation of this serialized instance.</returns>
    public string Serialize()
    {
      using (StringWriter textWriter = new StringWriter())
      {
        Store.Serialize(textWriter, this);
        return textWriter.ToString();
      }
    }

    public List<SetupOption> SetupOptions
    {
      get
      {
        return setupOptions;
      }

      set
      {
        setupOptions = value;
      }
    }
  }
}