﻿using DynamicTranslator.Dependency.Markers;

namespace DynamicTranslator.ViewModel
{
    public class Notifications : MultiThreadObservableCollection<Notification>, ITransientDependency {}
}