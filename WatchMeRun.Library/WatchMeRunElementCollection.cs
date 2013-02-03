using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WatchMeRun.Library
{
  public class WatchMeRunElementCollection : ConfigurationElementCollection
  {
    public override ConfigurationElementCollectionType CollectionType
    {
      get
      {
        return ConfigurationElementCollectionType.AddRemoveClearMap;
      }
    }

    protected override ConfigurationElement CreateNewElement(string filename)
    {
      return new WatchMeRunConfigElement(filename);
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return new WatchMeRunConfigElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((WatchMeRunConfigElement)element).FileName;
    }

    public WatchMeRunConfigElement this[int index]
    {
      get
      {
        return (WatchMeRunConfigElement)BaseGet(index);
      }
      set
      {
        if(BaseGet(index) != null)  
        {
          BaseRemoveAt(index);
        }
        BaseAdd(index,value);
      }
    
    }

    new public WatchMeRunConfigElement this[string fileName]
    {
      get
      {
        return (WatchMeRunConfigElement)BaseGet(fileName);
      }
    }

    public int IndexOf(WatchMeRunConfigElement element)
    {
      return BaseIndexOf(element);
    }

    public void Add(WatchMeRunConfigElement element)
    {
      BaseAdd(element);
    }

    public void Remove(WatchMeRunConfigElement element)
    {
      if (BaseIndexOf(element) >= 0)
          BaseRemove(element.FileName);
    }

    public void RemoveAt(int index)
    {
      BaseRemoveAt(index);
    }

    public void Remove(string filename)
    {
      BaseRemove(filename);
    }

    public void Clear()
    {
      BaseClear();
    }
  }

  public class WatchMeRunConfigElement : ConfigurationElement
  {
    public string Path {get;set;}
    public string FileName {get;set;}
    public string Command {get;set;}

    public WatchMeRunConfigElement()
    {

    }

    public WatchMeRunConfigElement(string filename)
    {
      FileName = filename;
    }

    public WatchMeRunConfigElement(string path, string filename, string command)
    {
      Path = path;
      FileName = filename;
      Command = command;
    }
  }
}
