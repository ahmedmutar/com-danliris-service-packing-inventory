using System;
using System.Collections.Generic;
using Com.Moonlay.Models;

namespace Com.Danliris.Service.Packing.Inventory.Data.Models
{
    public class SKUInventoryDocumentModel : StandardEntity
    {
        public SKUInventoryDocumentModel()
        {

        }

        public SKUInventoryDocumentModel(
            string documentNo,
            DateTimeOffset date,
            List<SKUInventoryDocumentItemModel> items,
            string referenceNo,
            string referenceType,
            string status,
            string storage,
            int storageId,
            string remark
        )
        {
            DocumentNo = documentNo;
            Date = date;
            Items = items;
            ReferenceNo = referenceNo;
            ReferenceType = referenceType;
            Status = status;
            Storage = storage;
            StorageId = storageId;
            Remark = remark;
        }

        public string DocumentNo { get; set; }
        public DateTimeOffset Date { get; set; }
        public List<SKUInventoryDocumentItemModel> Items { get; set; }
        public string ReferenceNo { get; set; }
        public string ReferenceType { get; set; }
        public string Status { get; set; }
        public string Storage { get; set; }
        public int StorageId { get; set; }
        public string Remark { get; set; }
    }
}