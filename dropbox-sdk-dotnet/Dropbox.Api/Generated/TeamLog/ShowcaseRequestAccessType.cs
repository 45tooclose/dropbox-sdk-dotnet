// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The showcase request access type object</para>
    /// </summary>
    public class ShowcaseRequestAccessType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShowcaseRequestAccessType> Encoder = new ShowcaseRequestAccessTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShowcaseRequestAccessType> Decoder = new ShowcaseRequestAccessTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseRequestAccessType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public ShowcaseRequestAccessType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseRequestAccessType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ShowcaseRequestAccessType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the showcase request access type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShowcaseRequestAccessType" />.</para>
        /// </summary>
        private class ShowcaseRequestAccessTypeEncoder : enc.StructEncoder<ShowcaseRequestAccessType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShowcaseRequestAccessType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShowcaseRequestAccessType" />.</para>
        /// </summary>
        private class ShowcaseRequestAccessTypeDecoder : enc.StructDecoder<ShowcaseRequestAccessType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ShowcaseRequestAccessType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShowcaseRequestAccessType Create()
            {
                return new ShowcaseRequestAccessType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ShowcaseRequestAccessType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
