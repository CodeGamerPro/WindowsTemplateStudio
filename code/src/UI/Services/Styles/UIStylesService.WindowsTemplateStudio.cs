﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows;
using System.Windows.Media;

namespace Microsoft.Templates.UI.Services
{
    public partial class UIStylesService
    {
        public static readonly DependencyProperty CardTitleTextProperty = DependencyProperty.Register("CardTitleText", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardTitleText
        {
            get { return (Brush)GetValue(CardTitleTextProperty); }
            set { SetValue(CardTitleTextProperty, value); }
        }

        public static readonly DependencyProperty CardDescriptionTextProperty = DependencyProperty.Register("CardDescriptionText", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardDescriptionText
        {
            get { return (Brush)GetValue(CardDescriptionTextProperty); }
            set { SetValue(CardDescriptionTextProperty, value); }
        }

        public static readonly DependencyProperty CardIconProperty = DependencyProperty.Register("CardIcon", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardIcon
        {
            get { return (Brush)GetValue(CardIconProperty); }
            set { SetValue(CardIconProperty, value); }
        }

        public static readonly DependencyProperty CardFooterTextProperty = DependencyProperty.Register("CardFooterText", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardFooterText
        {
            get { return (Brush)GetValue(CardFooterTextProperty); }
            set { SetValue(CardFooterTextProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundDefaultProperty = DependencyProperty.Register("CardBackgroundDefault", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBackgroundDefault
        {
            get { return (Brush)GetValue(CardBackgroundDefaultProperty); }
            set { SetValue(CardBackgroundDefaultProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundFocusProperty = DependencyProperty.Register("CardBackgroundFocus", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBackgroundFocus
        {
            get { return (Brush)GetValue(CardBackgroundFocusProperty); }
            set { SetValue(CardBackgroundFocusProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundHoverProperty = DependencyProperty.Register("CardBackgroundHover", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBackgroundHover
        {
            get { return (Brush)GetValue(CardBackgroundHoverProperty); }
            set { SetValue(CardBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundPressedProperty = DependencyProperty.Register("CardBackgroundPressed", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBackgroundPressed
        {
            get { return (Brush)GetValue(CardBackgroundPressedProperty); }
            set { SetValue(CardBackgroundPressedProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundSelectedProperty = DependencyProperty.Register("CardBackgroundSelected", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBackgroundSelected
        {
            get { return (Brush)GetValue(CardBackgroundSelectedProperty); }
            set { SetValue(CardBackgroundSelectedProperty, value); }
        }

        public static readonly DependencyProperty CardBackgroundDisabledProperty = DependencyProperty.Register("CardBackgroundDisabled", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBackgroundDisabled
        {
            get { return (Brush)GetValue(CardBackgroundDisabledProperty); }
            set { SetValue(CardBackgroundDisabledProperty, value); }
        }

        public static readonly DependencyProperty CardBorderDefaultProperty = DependencyProperty.Register("CardBorderDefault", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBorderDefault
        {
            get { return (Brush)GetValue(CardBorderDefaultProperty); }
            set { SetValue(CardBorderDefaultProperty, value); }
        }

        public static readonly DependencyProperty CardBorderFocusProperty = DependencyProperty.Register("CardBorderFocus", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBorderFocus
        {
            get { return (Brush)GetValue(CardBorderFocusProperty); }
            set { SetValue(CardBorderFocusProperty, value); }
        }

        public static readonly DependencyProperty CardBorderHoverProperty = DependencyProperty.Register("CardBorderHover", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBorderHover
        {
            get { return (Brush)GetValue(CardBorderHoverProperty); }
            set { SetValue(CardBorderHoverProperty, value); }
        }

        public static readonly DependencyProperty CardBorderPressedProperty = DependencyProperty.Register("CardBorderPressed", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBorderPressed
        {
            get { return (Brush)GetValue(CardBorderPressedProperty); }
            set { SetValue(CardBorderPressedProperty, value); }
        }

        public static readonly DependencyProperty CardBorderSelectedProperty = DependencyProperty.Register("CardBorderSelected", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBorderSelected
        {
            get { return (Brush)GetValue(CardBorderSelectedProperty); }
            set { SetValue(CardBorderSelectedProperty, value); }
        }

        public static readonly DependencyProperty CardBorderDisabledProperty = DependencyProperty.Register("CardBorderDisabled", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush CardBorderDisabled
        {
            get { return (Brush)GetValue(CardBorderDisabledProperty); }
            set { SetValue(CardBorderDisabledProperty, value); }
        }

        public static readonly DependencyProperty DeleteTemplateIconProperty = DependencyProperty.Register("DeleteTemplateIcon", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush DeleteTemplateIcon
        {
            get { return (Brush)GetValue(DeleteTemplateIconProperty); }
            set { SetValue(DeleteTemplateIconProperty, value); }
        }

        public static readonly DependencyProperty SavedTemplateBackgroundHoverProperty = DependencyProperty.Register("SavedTemplateBackgroundHover", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush SavedTemplateBackgroundHover
        {
            get { return (Brush)GetValue(SavedTemplateBackgroundHoverProperty); }
            set { SetValue(SavedTemplateBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusNewFileProperty = DependencyProperty.Register("NewItemFileStatusNewFile", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush NewItemFileStatusNewFile
        {
            get { return (Brush)GetValue(NewItemFileStatusNewFileProperty); }
            set { SetValue(NewItemFileStatusNewFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusModifiedFileProperty = DependencyProperty.Register("NewItemFileStatusModifiedFile", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush NewItemFileStatusModifiedFile
        {
            get { return (Brush)GetValue(NewItemFileStatusModifiedFileProperty); }
            set { SetValue(NewItemFileStatusModifiedFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusConflictingFileProperty = DependencyProperty.Register("NewItemFileStatusConflictingFile", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush NewItemFileStatusConflictingFile
        {
            get { return (Brush)GetValue(NewItemFileStatusConflictingFileProperty); }
            set { SetValue(NewItemFileStatusConflictingFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusConflictingStylesFileProperty = DependencyProperty.Register("NewItemFileStatusConflictingStylesFile", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush NewItemFileStatusConflictingStylesFile
        {
            get { return (Brush)GetValue(NewItemFileStatusConflictingStylesFileProperty); }
            set { SetValue(NewItemFileStatusConflictingStylesFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusWarningFileProperty = DependencyProperty.Register("NewItemFileStatusWarningFile", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush NewItemFileStatusWarningFile
        {
            get { return (Brush)GetValue(NewItemFileStatusWarningFileProperty); }
            set { SetValue(NewItemFileStatusWarningFileProperty, value); }
        }

        public static readonly DependencyProperty NewItemFileStatusUnchangedFileProperty = DependencyProperty.Register("NewItemFileStatusUnchangedFile", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush NewItemFileStatusUnchangedFile
        {
            get { return (Brush)GetValue(NewItemFileStatusUnchangedFileProperty); }
            set { SetValue(NewItemFileStatusUnchangedFileProperty, value); }
        }

        public static readonly DependencyProperty ChangesSummaryDetailFileHeaderBackgroundProperty = DependencyProperty.Register("ChangesSummaryDetailFileHeaderBackground", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush ChangesSummaryDetailFileHeaderBackground
        {
            get { return (Brush)GetValue(ChangesSummaryDetailFileHeaderBackgroundProperty); }
            set { SetValue(ChangesSummaryDetailFileHeaderBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HeaderTextSecondaryProperty = DependencyProperty.Register("HeaderTextSecondary", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush HeaderTextSecondary
        {
            get { return (Brush)GetValue(HeaderTextSecondaryProperty); }
            set { SetValue(HeaderTextSecondaryProperty, value); }
        }

        public static readonly DependencyProperty WizardFooterTextProperty = DependencyProperty.Register("WizardFooterText", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush WizardFooterText
        {
            get { return (Brush)GetValue(WizardFooterTextProperty); }
            set { SetValue(WizardFooterTextProperty, value); }
        }

        public static readonly DependencyProperty TemplateInfoPageDescriptionProperty = DependencyProperty.Register("TemplateInfoPageDescription", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush TemplateInfoPageDescription
        {
            get { return (Brush)GetValue(TemplateInfoPageDescriptionProperty); }
            set { SetValue(TemplateInfoPageDescriptionProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemActiveProperty = DependencyProperty.Register("SelectedItemActive", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush SelectedItemActive
        {
            get { return (Brush)GetValue(SelectedItemActiveProperty); }
            set { SetValue(SelectedItemActiveProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemActiveTextProperty = DependencyProperty.Register("SelectedItemActiveText", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush SelectedItemActiveText
        {
            get { return (Brush)GetValue(SelectedItemActiveTextProperty); }
            set { SetValue(SelectedItemActiveTextProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemInactiveProperty = DependencyProperty.Register("SelectedItemInactive", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush SelectedItemInactive
        {
            get { return (Brush)GetValue(SelectedItemInactiveProperty); }
            set { SetValue(SelectedItemInactiveProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemInactiveTextProperty = DependencyProperty.Register("SelectedItemInactiveText", typeof(Brush), typeof(UIStylesService), new PropertyMetadata(null));

        public Brush SelectedItemInactiveText
        {
            get { return (Brush)GetValue(SelectedItemInactiveTextProperty); }
            set { SetValue(SelectedItemInactiveTextProperty, value); }
        }
    }
}
