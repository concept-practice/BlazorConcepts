using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConcepts.Pages.Store
{
    public interface IStore
    {
        void AddHandler(EventHandler<IAction> action);
        void RemoveHandler(EventHandler<IAction> action);
    }
}
