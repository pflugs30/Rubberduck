﻿using Rubberduck.Refactorings.ExtractInterface;
using Rubberduck.Refactorings;

namespace Rubberduck.UI.Refactorings.ExtractInterface
{
    internal class ExtractInterfacePresenter : RefactoringPresenterBase<ExtractInterfaceModel>, IExtractInterfacePresenter
    {
        private static readonly DialogData DialogData = DialogData.Create(RefactoringsUI.ExtractInterface_Caption, 339, 459);

        public ExtractInterfacePresenter(ExtractInterfaceModel model,
            IRefactoringDialogFactory dialogFactory) : base(DialogData, model, dialogFactory) { }

        public override ExtractInterfaceModel Show()
        {
            return Model.TargetDeclaration == null ? null : base.Show();
        }
    }
}
