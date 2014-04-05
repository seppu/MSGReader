﻿namespace DocumentServices.Modules.Readers.MsgReader.Outlook
{
    /// <summary>
    /// Contains all MAPI related constants
    /// </summary>
    internal static class MapiConsts
    {
        /*

            Property Identifier Ranges

            MAPI defines ranges of property identifiers. Each range is reserved for a special purpose. 
            The following table summarizes the different ranges for property identifiers, describing the owner for 
            the properties in each range. 
         
            0000 	        Reserved by MAPI for the special value PR_NULL
            0001 - 0BFF 	Message envelope properties defined by MAPI
            0C00 - 0DFF 	Recipient properties defined by MAPI
            0E00 - 0FFF 	Non-transmittable message properties defined by MAPI
            1000 - 2FFF 	Message content properties defined by MAPI
            3000 - 3FFF 	Properties for objects other than messages and recipients defined by MAPI
            4000 - 57FF 	Message envelope properties defined by transport providers
            5800 - 5FFF 	Recipient properties defined by transport and address book providers
            6000 - 65FF 	Non-transmittable message properties defined by clients
            6600 - 67FF 	Non-transmittable properties defined by a service provider. These properties can be visible or invisible to users
            6800 - 7BFF 	Message content properties for custom message classes defined by creators of those classes
            7C00 - 7FFF 	Non-transmittable properties for custom message classes defined by creators of those classes
            8000 - FFFE 	Properties defined by clients and occasionally service providers that are identified by name.
            FFFF 	        Reserved by MAPI for the special error value PROP_ID_INVALID
         
           named property: A property that is identified by both a GUID and either a string name or a 32-bit identifier.
           property ID   : A 16-bit numeric identifier of a specific attribute (1). A property ID does not include any property type information.
        */

        // ReSharper disable InconsistentNaming
        #region Value types
        /// <summary>
        /// (Reserved for interface use) type doesn't matter to caller
        /// </summary>
        public const ushort PT_UNSPECIFIED = 0;

        /// <summary>
        /// NULL property value
        /// </summary>
        public const ushort PT_NULL = 1;

        /// <summary>
        /// Signed 16-bit value
        /// </summary>
        public const ushort PT_I2 = 2;

        /// <summary>
        /// Signed 32-bit value
        /// </summary>
        public const ushort PT_LONG = 3;

        /// <summary>
        /// 4-byte floating point
        /// </summary>
        public const ushort PT_R4 = 4;

        /// <summary>
        /// Floating point double
        /// </summary>
        public const ushort PT_DOUBLE = 5;

        /// <summary>
        /// Signed 64-bit int (decimal w/4 digits right of decimal pt)
        /// </summary>
        public const ushort PT_CURRENCY = 6;

        /// <summary>
        /// Application time
        /// </summary>
        public const ushort PT_APPTIME = 7;

        /// <summary>
        /// 32-bit error value
        /// </summary>
        public const ushort PT_ERROR = 10;

        /// <summary>
        /// 16-bit boolean (non-zero true)
        /// </summary>
        public const ushort PT_BOOLEAN = 11;

        /// <summary>
        /// Embedded object in a property
        /// </summary>
        public const ushort PT_OBJECT = 13;

        /// <summary>
        /// 8-byte signed integer
        /// </summary>
        public const ushort PT_I8 = 20;

        /// <summary>
        /// Null terminated 8-bit character string
        /// </summary>
        public const ushort PT_STRING8 = 30;

        /// <summary>
        /// Null terminated Unicode string
        /// </summary>
        public const ushort PT_UNICODE = 31;

        /// <summary>
        /// FILETIME 64-bit int w/ number of 100ns periods since Jan 1,1601
        /// </summary>
        public const ushort PT_SYSTIME = 64;

        /// <summary>
        /// OLE GUID
        /// </summary>
        public const ushort PT_CLSID = 72;

        /// <summary>
        /// Uninterpreted (counted byte array)
        /// </summary>
        public const ushort PT_BINARY = 258;

        /// <summary>
        /// Multi-view unicode string
        /// </summary>
        public const ushort PT_MV_UNICODE = 4127;
        #endregion

        /// <summary>
        /// Gives the type of class that is used for the msg file:
        /// - IPM.Note = E-mail
        /// - IMP.Appointment = "Agenda item" 
        /// </summary>
        public const string PR_MESSAGE_CLASS = "001A";

        #region Attachment constants
        /// <summary>
        /// Prefix that is placed before an attachment tag
        /// </summary>
        public const string AttachStoragePrefix = "__attach_version1.0_#";

        /// <summary>
        /// Name of the attachment
        /// </summary>
        public const string PR_ATTACH_FILENAME = "3704";

        /// <summary>
        /// Long name of the attachment
        /// </summary>
        public const string PR_ATTACH_LONG_FILENAME = "3707";

        /// <summary>
        /// Attachment data
        /// </summary>
        public const string PR_ATTACH_DATA = "3701";
        
        /// <summary>
        /// Method that is used to embed the attachment e.g. inline
        /// </summary>
        public const string PR_ATTACH_METHOD = "3705";

        /// <summary>
        /// Position in the HTML body for the attachment
        /// </summary>
        public const string PR_RENDERING_POSITION = "370B";

        /// <summary>
        /// Content ID from the attachment
        /// </summary>
        public const string PR_ATTACH_CONTENTID = "3712";

        /// <summary>
        /// There is no attachment
        /// </summary>
        public const int NO_ATTACHMENT = 0;
        public const int ATTACH_BY_VALUE = 1;
        public const int ATTACH_BY_REFERENCE = 2;
        public const int ATTACH_BY_REF_RESOLVE = 3;
        public const int ATTACH_BY_REF_ONLY = 4;

        /// <summary>
        /// The attachment is a msg file
        /// </summary>
        public const int ATTACH_EMBEDDED_MSG = 5;

        /// <summary>
        /// The attachment in an OLE object
        /// </summary>
        public const int ATTACH_OLE = 6;
        #endregion

        #region MSG contstants
        /// <summary>
        /// Storage prefix tag
        /// </summary>
        public const string RecipStoragePrefix = "__recip_version1.0_#";

        /// <summary>
        /// Displayname e.g. Kees van Spelde
        /// </summary>
        public const string PR_DISPLAY_NAME = "3001";

        /// <summary>
        /// Filled with the TO name when an E-mail has been sent
        /// </summary>
        public const string PR_DISPLAY_TO = "0E40";

        /// <summary>
        /// Filled with the CC name when an E-mail has been sent
        /// </summary>
        public const string PR_DISPLAY_CC = "0E03";

        /// <summary>
        /// Filled with the BCC name when an E-mail has been sent
        /// </summary>
        public const string PR_DISPLAY_BCC = "0E02";

        /// <summary>
        /// E-mail address e.g. PeterPan@neverland.com
        /// </summary>
        public const string PR_EMAIL = "39FE";

        /// <summary>
        /// Second place to search for an E-mail address
        /// </summary>
        public const string PR_EMAIL_2 = "403E";

        /// <summary>
        /// Type of the recipient
        /// </summary>
        public const string PR_RECIPIENT_TYPE = "0C15";

        /// <summary>
        /// E-mail To address
        /// </summary>
        public const int MAPI_TO = 1;

        /// <summary>
        /// E-mail From address
        /// </summary>
        public const int MAPI_CC = 2;

        /// <summary>
        /// E-mail BCC address
        /// </summary>
        public const int MAPI_BCC = 3;

        /// <summary>
        /// E-mail subject
        /// </summary>
        public const string PR_SUBJECT = "0037";

        /// <summary>
        /// The date and time when the E-mail has been sent
        /// </summary>
        public const string PR_CLIENT_SUBMIT_TIME = "0039";

        /// <summary>
        /// Property to indicate the date and time that the message store provider marked the message as having been sent.
        /// </summary>
        public const string PR_PROVIDER_SUBMIT_TIME = "0048";

        /// <summary>
        /// The date and time when the E-mail has been delivered to the addressee
        /// </summary>
        public const string PR_MESSAGE_DELIVERY_TIME = "0E06";

        /// <summary>
        /// The text body of the E-mail
        /// </summary>
        public const string PR_BODY = "1000";

        /// <summary>
        /// The HTML body of the E-mail
        /// </summary>
        public const string PR_BODY_HTML = "1013";

        /// <summary>
        /// The RTF body of the E-mail, this one can contain the HTML body embedded into the RTF
        /// </summary>
        public const string PR_RTF_COMPRESSED = "1009";

        /// <summary>
        /// Gives the codepage used in the body or html
        /// </summary>
        public const string PR_INTERNET_CPID = "3FDE"; 

        /// <summary>
        /// Name of the sender e.g. Kees van Spelde
        /// </summary>
        public const string PR_SENDER_NAME = "0C1A";

        /// <summary>
        /// E-mail address of the sender e.g. PeterPan@neverland.com
        /// </summary>
        public const string PR_SENDER_EMAIL_ADDRESS = "0C1F";

        /// <summary>
        /// E-mail address of the sender e.g. PeterPan@neverland.com
        /// </summary>
        public const string PR_SENDER_EMAIL_ADDRESS_2 = "8012";

        /// <summary>
        /// E-mail importance flag (high, normal, low)
        /// </summary>
        public const string PR_IMPORTANCE = "0017";
        #endregion

        #region Flag constants
        /// <summary>
        /// E-mail follow up flag
        /// </summary>
        public const string FlagRequest = "FlagRequest";

        /// <summary>
        /// Specifies the flag state of the message object; Not present, 1 = Completed, 2 = Flagged.
        /// Only available from Outlook 2007 and up.
        /// </summary>
        public const string PR_FLAG_STATUS = "1090";

        /// <summary>
        /// Contains the date when the task was completed. Only filled when <see cref="TaskComplete"/> is true.
        /// Only available from Outlook 2007 and up.
        /// </summary>
        public const string PR_FLAG_COMPLETE_TIME = "1091";
        #endregion

        #region Task constants
        /// <summary>
        /// <see cref="TaskStatus"/> of the task
        /// </summary>
        public const string TaskStatus = "8006";

        /// <summary>
        /// Start date of the task
        /// </summary>
        public const string TaskStartDate = "8008";

        /// <summary>
        /// Due date of the task
        /// </summary>
        public const string TaskDueDate = "8009";

        /// <summary>
        /// True when the task is complete
        /// </summary>
        public const string TaskComplete = "8014";
        #endregion

        #region Appointment constants
        /// <summary>
        /// Appointment location
        /// </summary>
        public const string Location = "8208";

        /// <summary>
        /// Appointment reccurence type
        /// </summary>
        public const string ReccurrenceType = "ReccurrenceType";

        /// <summary>
        /// Appointment reccurence pattern
        /// </summary>
        public const string ReccurrencePattern = "ReccurrencePattern";

        /// <summary>
        /// Appointment start time (greenwich time)
        /// </summary>
        public const string AppointmentStartWhole = "AppointmentStartWhole";

        /// <summary>
        /// Appointment end time (greenwich time)
        /// </summary>
        public const string AppointmentEndWhole = "AppointmentEndWhole";
        #endregion

        /// <summary>
        /// Specifies the color to be used when displaying a Calendar object
        /// </summary>
        public const string PidNameKeywords = "PidNameKeywords";

        /// <summary>
        /// Can contain the internet E-mail headers
        /// </summary>
        public const string PR_TRANSPORT_MESSAGE_HEADERS_1 = "007D001E";

        /// <summary>
        /// Can contain the internet E-mail headers
        /// </summary>
        public const string PR_TRANSPORT_MESSAGE_HEADERS_2 = "007D001F";

        #region Stream constants
        /// <summary>
        /// Sub storage version 1.0 streams
        /// </summary>
        public const string SubStgVersion1 = "__substg1.0";

        /// <summary>
        /// Stream that contains the internet E-mail headers
        /// </summary>
        public const string HeaderStreamName = "__substg1.0_007D001F";

        /// <summary>
        /// The stream that contains all the MAPI properties
        /// </summary>
        public const string PropertiesStream = "__properties_version1.0";

        /// <summary>
        /// Contains the streams needed to perform named property mapping
        /// </summary>
        public const string NameIdStorage = "__nameid_version1.0";

        /// <summary>
        /// The stream with the name properties are always in stream "__substg1.0_00030102"
        /// </summary>
        public const string NameIdStorageMappingStream = "__substg1.0_00030102";

        /// <summary>
        /// 
        /// </summary>
        public const int PropertiesStreamHeaderTop = 32;
        public const int PropertiesStreamHeaderEmbeded = 24;
        public const int PropertiesStreamHeaderAttachOrRecip = 8;
        #endregion
        // ReSharper restore InconsistentNaming
    }
}