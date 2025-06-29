﻿namespace Boilerplate.MVC
{
    public class Controller<TModelType, TViewType> where TModelType : Model where TViewType : View
    {
        public TModelType Model { get; protected set; }
  
        public Controller(TModelType model)
        {
            Model = model;
        }

        public virtual void BindView(TViewType view)
        {
            
        }
    }
}