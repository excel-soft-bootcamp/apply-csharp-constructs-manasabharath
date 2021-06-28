using System;

namespace TataCarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DiCorEngine dicorengine = new DiCorEngine();
            TataCar _harrier = new TataCar(dicorengine);
            _harrier.Drive();
            _harrier.Halt();

            VeriCorEngine vericorengine = new VeriCorEngine();
            TataCar _nexon = new TataCar(vericorengine);
            _nexon.Drive();
            _nexon.Halt();

            MultiJetEngine multijetengine = new MultiJetEngine();
            TataCar _hexa = new TataCar(multijetengine);
            _hexa.Drive();
            _hexa.Halt();


            RevorTron revortron = new RevorTron();
            TataCar _safari = new TataCar(revortron);
            _safari.Drive();
            _safari.Halt();
        }
    }
}
