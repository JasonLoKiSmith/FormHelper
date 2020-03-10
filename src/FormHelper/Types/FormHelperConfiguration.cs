﻿namespace FormHelper
{
    public class FormHelperConfiguration
    {
        public string CheckTheFormFieldsMessage { get; set; } = "Check the form fields.";
        public int RedirectDelay { get; set; } = 1500;
        public ToastrPosition ToastrDefaultPosition = ToastrPosition.TopRight;
    }
}
