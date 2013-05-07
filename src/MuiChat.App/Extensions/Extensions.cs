namespace MuiChat.App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition.Hosting;
    using System.ComponentModel.Composition.Primitives;

    public static class CompositionBatchExtension
    {
        public static ComposablePart AddExport<TKey>(this CompositionBatch batch, Func<object> func)
        {
            var typeString = typeof(TKey).ToString();
            return batch.AddExport(
                new Export(
                    new ExportDefinition(
                        typeString,
                        new Dictionary<string, object>() { { "ExportTypeIdentity", typeString } }),
                    func));

        }
    }
}
