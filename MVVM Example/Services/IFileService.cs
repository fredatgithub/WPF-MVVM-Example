using MVVM_Example.Model;
using System.Collections.Generic;

namespace MVVM_Example.ViewModel
{
  public interface IFileService
  {
    List<Phone> Open(string fileName);
    void Save(string fileName, List<Phone> phoneList);
  }
}