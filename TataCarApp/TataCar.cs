﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarApp
{
    class TataCar
    {
        IEngine _engine;

        public TataCar(IEngine engine)
        {
            this._engine = engine;
        }
        public void Drive()
        {

            _engine.Start();
        }
        public void Halt()
        {

            _engine.Stop();
        }
    }
}