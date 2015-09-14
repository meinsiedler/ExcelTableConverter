﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.LatexTableConverter.BorderStylers;
using ExcelTableConverter.LatexTableConverter.CellFormaters;
using ExcelTableConverter.LatexTableConverter.Justifiers;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.LatexTableConverter
{
  public class LatexConverter : BaseTableConverter
  {
    private readonly ExtendedFeaturesModel _extendedFeatures;
    private readonly ICellFormatter _cellFormatter;

    public LatexConverter()
    {
      AddConverter(ConverterName(), this);
      _extendedFeatures = new ExtendedFeaturesModel();
      _cellFormatter = new AllStylesCellFormatter();
    }

    private string ConverterName()
    {
      return "LaTeX";
    }

    public override string ToString()
    {
      return ConverterName();
    }

    public override string GetConvertedContent(Table table)
    {
      if (table != null && table.Rows.Count > 0)
      {
        StringBuilder returnValue = new StringBuilder();
        returnValue.Append(AppendBeginTableEnvironmentIfSet());
        returnValue.Append(AppendBeginTabular());
        returnValue.Append(AppendColumnDefinitions(table.Rows[0]));
        returnValue.Append(CloseBeginTabular());
        returnValue.Append(AppendHorizontalRuleIfSet(table.Rows[0], false));
        returnValue.Append(AppendNewLine());

        returnValue.Append(AppendTableContent(table, table.Rows[0]));

        returnValue.Append(AppendEndTabular());
        returnValue.Append(AppendEndTableEnvironmentIfSet(table));

        return returnValue.ToString();
      }      
      throw new ArgumentException("table is null");
    }

    private string AppendTableContent(Table table, Row firstRow)
    {
      StringBuilder tableContent = new StringBuilder();
      foreach (Row row in table.Rows)
      {
        tableContent.Append(AppendRow(row, firstRow));
      }
      return tableContent.ToString();
    }

    private StringBuilder AppendRow(Row actualRow, Row firstRow)
    {
      StringBuilder rowContent = new StringBuilder();
      var cells = actualRow.Columns as IList<Cell> ?? actualRow.Columns.ToList();
      for (int i = 0; i < cells.Count(); i++)
      {
        var preparedValue = PrepareCellValue(cells[i], firstRow.Columns[i]);
        rowContent.Append(AppendValueWithCellSeperator(preparedValue));
      }
      rowContent = RemoveLastCellSeperator(rowContent);
      rowContent.Append(AppendQuitLineAndAddHorizontalRuleIfSet(actualRow));
      rowContent.Append(AppendNewLine());
      return rowContent;
    }

    private static string AppendValueWithCellSeperator(string preparedValue)
    {
      return string.Format("{0} & ", preparedValue);
    }

    private string PrepareCellValue(Cell cell, Cell firstRowCell)
    {
      cell.Text = ReplaceConstantsIfSet(cell.Text);
      var cellValue = _cellFormatter.Format(cell, _extendedFeatures, firstRowCell);
      return cellValue;
    }

    private StringBuilder RemoveLastCellSeperator(StringBuilder tableContent)
    {
      return tableContent.Remove(tableContent.Length - 2, 2);
    }

    private string ReplaceConstantsIfSet(string cellValue)
    {
      if (_extendedFeatures.ReplaceConstants)
      {
        cellValue = LatexConstants.Constants.Aggregate(cellValue,
                                                       (current, value) => current.Replace(value.Key, value.Value));
      }
      return cellValue;
    }

    private string AppendBeginTableEnvironmentIfSet()
    {
      return _extendedFeatures.AddTableEnvironment ? "\\begin{table}[!ht]"+ AppendNewLine() + "\\centering" + AppendNewLine() : string.Empty;
    }

    private string AppendBeginTabular()
    {
      return "\\begin{tabular}{|";
    }

    private string AppendColumnDefinitions(Row firstRow)
    {
      var columns = "";

      foreach (Cell cell in firstRow.Columns)
      {
        var justifier = JustifierFactory.GetJustifier(cell, _extendedFeatures.AutoJustify);
        columns += justifier.GetAlignment();
        columns += AppendVerticalBorders();
      }
      return columns;
    }

    private string AppendVerticalBorders()
    {
      return _extendedFeatures.UseBorders ? "|" : string.Empty;
    }

    private string CloseBeginTabular()
    {
      return string.Format("}}{0}", AppendNewLine());
    }

    private string AppendFullBorderConfig(Row row, bool useBottomRuleFromRow)
    {
      Dictionary<Row, HorizontalRuleStyler> horizontalRuleStylers;
      var fullBorders = new StringBuilder();
      if (useBottomRuleFromRow)
      {
        horizontalRuleStylers = HorizontalRuleStylerFactory.GetBottomHorizontalRuleStyler(row);
        foreach (var horizontalRuleStyler in horizontalRuleStylers)
        {
          fullBorders.Append(horizontalRuleStyler.Value.GetBottomHorizontalRule(horizontalRuleStyler.Key));
        }
      }
      else
      {
        horizontalRuleStylers = HorizontalRuleStylerFactory.GetTopHorizontalRuleStyler(row);
        foreach (var horizontalRuleStyler in horizontalRuleStylers)
        {
          fullBorders.Append(horizontalRuleStyler.Value.GetTopHorizontalRule(horizontalRuleStyler.Key));
        }
      }
      return fullBorders.ToString();
    }

    private string AppendHorizontalRuleIfSet(Row row, bool useBottomRuleFromRow)
    {
      if (_extendedFeatures.AddHline)
      {
        return "\\hline";
      }

      if (_extendedFeatures.FullBorderConfig)
      {
        return AppendFullBorderConfig(row, useBottomRuleFromRow);
      }
      return string.Empty;
    }

    private string AppendQuitLineAndAddHorizontalRuleIfSet(Row row)
    {
      return string.Format("\\\\{0}", AppendHorizontalRuleIfSet(row, true));
    }

    private string AppendNewLine()
    {
      return Environment.NewLine;
    }

    private string AppendEndTabular()
    {
      return AppendNewLine() + "\\end{tabular}";
    }

    private string AppendEndTableEnvironmentIfSet(Table table)
    {
      if (_extendedFeatures.AddTableEnvironment)
      {
        var tableEnvironment = AppendNewLine();
        tableEnvironment += AppendCaption(table);
        tableEnvironment += AppendEndTable();
        return tableEnvironment;
      }
      return string.Empty;
    }

    private string AppendCaption(Table table)
    {
      return string.Format("\\caption{{{0}}}{1}", GetCaptionName(table), AppendNewLine());
    }

    private string GetCaptionName(Table table)
    {
      return string.IsNullOrEmpty(_extendedFeatures.TableName)
               ? table.SheetName
               : _extendedFeatures.TableName;
    }

    private string AppendEndTable()
    {
      return "\\end{table}";
    }

    public override string GetFileExtension()
    {
      return "tex";
    }

    public override UserControl ExtendedFeaturesUserControl
    {
      get { return _extendedFeatures.BoundExtendedFeaturesUserControl; }
    }
    
  }
}
