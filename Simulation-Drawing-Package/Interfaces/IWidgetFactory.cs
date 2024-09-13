using System;
using Microsoft.Extensions.DependencyInjection;
using Simulation_Drawing_Package.Widgets;

namespace Simulation_Drawing_Package.Interfaces
{
    public interface IWidgetFactory
    {
        IWidget CreateWidget(string widgetType);
    }
}

