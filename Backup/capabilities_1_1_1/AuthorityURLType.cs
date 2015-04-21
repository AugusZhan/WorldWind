//
// AuthorityURLType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace capabilities_1_1_1
{
	public class AuthorityURLType : Altova.Xml.Node
	{
		#region Forward constructors
		public AuthorityURLType() : base() { SetCollectionParents(); }
		public AuthorityURLType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public AuthorityURLType(XmlNode node) : base(node) { SetCollectionParents(); }
		public AuthorityURLType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "name"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "name", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "OnlineResource"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "OnlineResource", i);
				InternalAdjustPrefix(DOMNode, false);
				new OnlineResourceType(DOMNode).AdjustPrefix();
			}
		}


		#region name accessor methods
		public int GetnameMinCount()
		{
			return 1;
		}

		public int nameMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetnameMaxCount()
		{
			return 1;
		}

		public int nameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetnameCount()
		{
			return DomChildCount(NodeType.Attribute, "", "name");
		}

		public int nameCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "name");
			}
		}

		public bool Hasname()
		{
			return HasDomChild(NodeType.Attribute, "", "name");
		}

		public SchemaString GetnameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "name", index)));
		}

		public SchemaString Getname()
		{
			return GetnameAt(0);
		}

		public SchemaString name
		{
			get
			{
				return GetnameAt(0);
			}
		}

		public void RemovenameAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "name", index);
		}

		public void Removename()
		{
			while (Hasname())
				RemovenameAt(0);
		}

		public void Addname(SchemaString newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "name", newValue.ToString());
		}

		public void InsertnameAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "name", index, newValue.ToString());
		}

		public void ReplacenameAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "name", index, newValue.ToString());
		}
		#endregion // name accessor methods

		#region name collection
        public nameCollection	Mynames = new nameCollection( );

        public class nameCollection: IEnumerable
        {
            AuthorityURLType parent;
            public AuthorityURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public nameEnumerator GetEnumerator() 
			{
				return new nameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class nameEnumerator: IEnumerator 
        {
			int nIndex;
			AuthorityURLType parent;
			public nameEnumerator(AuthorityURLType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.nameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetnameAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // name collection

		#region OnlineResource accessor methods
		public int GetOnlineResourceMinCount()
		{
			return 1;
		}

		public int OnlineResourceMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetOnlineResourceMaxCount()
		{
			return 1;
		}

		public int OnlineResourceMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetOnlineResourceCount()
		{
			return DomChildCount(NodeType.Element, "", "OnlineResource");
		}

		public int OnlineResourceCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "OnlineResource");
			}
		}

		public bool HasOnlineResource()
		{
			return HasDomChild(NodeType.Element, "", "OnlineResource");
		}

		public OnlineResourceType GetOnlineResourceAt(int index)
		{
			return new OnlineResourceType(GetDomChildAt(NodeType.Element, "", "OnlineResource", index));
		}

		public OnlineResourceType GetOnlineResource()
		{
			return GetOnlineResourceAt(0);
		}

		public OnlineResourceType OnlineResource
		{
			get
			{
				return GetOnlineResourceAt(0);
			}
		}

		public void RemoveOnlineResourceAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "OnlineResource", index);
		}

		public void RemoveOnlineResource()
		{
			while (HasOnlineResource())
				RemoveOnlineResourceAt(0);
		}

		public void AddOnlineResource(OnlineResourceType newValue)
		{
			AppendDomElement("", "OnlineResource", newValue);
		}

		public void InsertOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			InsertDomElementAt("", "OnlineResource", index, newValue);
		}

		public void ReplaceOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			ReplaceDomElementAt("", "OnlineResource", index, newValue);
		}
		#endregion // OnlineResource accessor methods

		#region OnlineResource collection
        public OnlineResourceCollection	MyOnlineResources = new OnlineResourceCollection( );

        public class OnlineResourceCollection: IEnumerable
        {
            AuthorityURLType parent;
            public AuthorityURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public OnlineResourceEnumerator GetEnumerator() 
			{
				return new OnlineResourceEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class OnlineResourceEnumerator: IEnumerator 
        {
			int nIndex;
			AuthorityURLType parent;
			public OnlineResourceEnumerator(AuthorityURLType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.OnlineResourceCount );
			}
			public OnlineResourceType  Current 
			{
				get 
				{
					return(parent.GetOnlineResourceAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // OnlineResource collection

        private void SetCollectionParents()
        {
            Mynames.Parent = this; 
            MyOnlineResources.Parent = this; 
	}
}
}