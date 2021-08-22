using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
  public  interface IDataResult<T>:IResult
    {
        //IResult implement edildigi icin onun icindeki Success ve Message propertiesleri her ne kadar
        //otomatik olarak IDataResult a gelmemisse de  o propertiesler IDataResult un propertiesleri gibidir
        
        T Data { get; }

    }
}
