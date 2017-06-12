﻿using Microsoft.Templates.Core.Gen;
using Microsoft.Templates.Core.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace Microsoft.Templates.UI.ViewModels.NewItem
{
    public enum FileType { AddedFile, ModifiedFile, ConflictingFile, WarningFile }
    public abstract class BaseNewItemFileViewModel : Observable
    {
        public string Subject { get; private set; }
        public ObservableCollection<CodeLineViewModel> NewFileLines { get; private set; } = new ObservableCollection<CodeLineViewModel>();
        public ObservableCollection<CodeLineViewModel> CurrentFileLines { get; private set; } = new ObservableCollection<CodeLineViewModel>();
        public ObservableCollection<CodeLineViewModel> MergedFileLines { get; private set; } = new ObservableCollection<CodeLineViewModel>();
        public ICommand UpdateFontSizeCommand { get; }
        public abstract FileType FileType { get; }

        public BaseNewItemFileViewModel(string subject)
        {
            Subject = subject;
            LoadFile();
        }

        private void LoadFile()
        {
            var newFilePath = Path.Combine(GenContext.Current.OutputPath, Subject);
            if (File.Exists(newFilePath))
            {
                uint lineNumber = 0;
                foreach (var line in File.ReadAllLines(newFilePath))
                {
                    NewFileLines.Add(new CodeLineViewModel(++lineNumber, line));
                }
            }
            var currentFilePath = Path.Combine(GenContext.Current.ProjectPath, Subject);
            if (File.Exists(currentFilePath))
            {
                uint lineNumber = 0;
                foreach (var line in File.ReadAllLines(currentFilePath))
                {
                    CurrentFileLines.Add(new CodeLineViewModel(++lineNumber, line));
                }
            }
            if (File.Exists(newFilePath) && File.Exists(currentFilePath))
            {
                MergedFileLines = MergeLines();
            }
        }

        private ObservableCollection<CodeLineViewModel> MergeLines()
        {
            var result = new ObservableCollection<CodeLineViewModel>();
            int index = 0;
            uint lineNumber = 0;
            foreach (var newFileLine in NewFileLines)
            {
                var currentLine = CurrentFileLines[index];
                if (currentLine.Line == newFileLine.Line)
                {
                    //Default
                    result.Add(new CodeLineViewModel(lineNumber, newFileLine));
                    index++;
                }
                else
                {
                    //New
                    result.Add(new CodeLineViewModel(lineNumber, newFileLine, LineStatus.New));
                }
                lineNumber++;
            }
            return result;
        }

        public void UpdateFontSize(double points)
        {
            if (NewFileLines != null && NewFileLines.Any())
            {
                foreach (var line in NewFileLines)
                {
                    line.FontSize = points;
                }
            }
            if (CurrentFileLines != null && CurrentFileLines.Any())
            {
                foreach (var line in CurrentFileLines)
                {
                    line.FontSize = points;
                }
            }
            if (MergedFileLines != null && MergedFileLines.Any())
            {
                foreach (var line in MergedFileLines)
                {
                    line.FontSize = points;
                }
            }
        }
    }
}