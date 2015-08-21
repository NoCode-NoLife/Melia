// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;

namespace Melia.Shared.Data
{
	public class DatabaseWarningException : Exception
	{
		public DatabaseWarningException(string msg)
			: base(msg)
		{ }

		public DatabaseWarningException(string msg, string source)
			: this(msg)
		{
			this.Source = source;
		}

		public override string ToString()
		{
			return this.Source + ": " + this.Message;
		}
	}

	public class DatabaseErrorException : Exception
	{
		public DatabaseErrorException(string msg)
			: base(msg)
		{ }

		public DatabaseErrorException(string msg, string source)
			: this(msg)
		{
			this.Source = source;
		}

		public override string ToString()
		{
			return this.Source + ": " + this.Message;
		}
	}

	public class CsvDatabaseWarningException : DatabaseWarningException
	{
		public int Line { get; set; }

		public CsvDatabaseWarningException(string source, int line, string msg, params object[] args)
			: base(string.Format(msg, args), source)
		{
			this.Line = line;
		}

		public CsvDatabaseWarningException(string msg)
			: base(msg)
		{ }

		public CsvDatabaseWarningException(string msg, params object[] args)
			: base(string.Format(msg, args))
		{ }

		public override string ToString()
		{
			return string.Format("{0} on line {1}: {2}", this.Source, this.Line, this.Message);
		}
	}

	public class FieldCountException : CsvDatabaseWarningException
	{
		public FieldCountException(int expectedAmount, int amount)
			: base("Expected at least {0} fields, found {1}.", expectedAmount, amount)
		{ }
	}
}
