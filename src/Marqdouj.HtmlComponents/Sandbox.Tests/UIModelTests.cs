using Marqdouj.HtmlComponents.UI;

namespace Sandbox.Tests
{
    [TestClass]
    public sealed class UIModelTests
    {
        #region FormatValue D

        [TestMethod]
        public void UIModel_FormatValue_D()
        {
            var obj = new UIModelTestClass { D = 123.406 };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.D))
            {
                FormatString = "N2",
                Source = obj
            };

            var value = model.FormatValue;

            Assert.AreEqual("123.41", value);
        }

        [TestMethod]
        public void UIModel_FormatValue_DN_WithValue()
        {
            var obj = new UIModelTestClass { DN = 123.406 };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.DN))
            {
                FormatString = "N2",
                Source = obj
            };

            var value = model.FormatValue;

            Assert.AreEqual("123.41", value);
        }

        [TestMethod]
        public void UIModel_FormatValue_DN_Null()
        {
            var obj = new UIModelTestClass { DN = null };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.DN))
            {
                FormatString = "N2",
                Source = obj
            };

            var value = model.FormatValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_FormatValue_D_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.D))
            {
                FormatString = "N2",
            };

            var value = model.FormatValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_FormatValue_DN_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.DN))
            {
                FormatString = "N2",
            };

            var value = model.FormatValue;

            Assert.IsNull(value);
        }

        #endregion

        #region BindValue D

        [TestMethod]
        public void UIModel_BindValue_D()
        {
            var obj = new UIModelTestClass();
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.D))
            {
                FormatString = "N2",
                Source = obj,
                BindValue = "123.406"
            };

            var value = model.BindValue;

            Assert.AreEqual("123.406", value);
        }

        [TestMethod]
        public void UIModel_BindValue_DN_WithValue()
        {
            var obj = new UIModelTestClass();
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.DN))
            {
                FormatString = "N2",
                Source = obj,
                BindValue = "123.406"
            };

            var value = model.BindValue;

            Assert.AreEqual("123.406", value);
        }

        [TestMethod]
        public void UIModel_BindValue_DN_Null()
        {
            var obj = new UIModelTestClass { DN = 123.406 };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.DN))
            {
                FormatString = "N2",
                Source = obj,
                BindValue = null
            };

            var value = model.BindValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_BindValue_D_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.D))
            {
                FormatString = "N2",
            };

            var value = model.BindValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_BindValue_DN_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.DN))
            {
                FormatString = "N2",
            };

            var value = model.BindValue;

            Assert.IsNull(value);
        }

        #endregion

        #region FormatValue S

        [TestMethod]
        public void UIModel_FormatValue_S()
        {
            var obj = new UIModelTestClass { S = "123.45678" };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.S))
            {
                FormatString = "N2",
                Source = obj
            };

            var value = model.FormatValue;

            Assert.AreEqual("123.45678", value);
        }

        [TestMethod]
        public void UIModel_FormatValue_SN_WithValue()
        {
            var obj = new UIModelTestClass { SN = "123.45678" };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.SN))
            {
                FormatString = "N2",
                Source = obj
            };

            var value = model.FormatValue;

            Assert.AreEqual("123.45678", value);
        }

        [TestMethod]
        public void UIModel_FormatValue_SN_Null()
        {
            var obj = new UIModelTestClass { SN = null };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.SN))
            {
                FormatString = "N2",
                Source = obj
            };

            var value = model.FormatValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_FormatValue_S_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.S))
            {
                FormatString = "N2",
            };

            var value = model.FormatValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_FormatValue_SN_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.SN))
            {
                FormatString = "N2",
            };

            var value = model.FormatValue;

            Assert.IsNull(value);
        }

        #endregion

        #region BindValue S

        [TestMethod]
        public void UIModel_BindValue_S()
        {
            var obj = new UIModelTestClass();
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.S))
            {
                FormatString = "N2",
                Source = obj,
                BindValue = "123.45678"
            };

            var value = model.BindValue;

            Assert.AreEqual("123.45678", value);
        }

        [TestMethod]
        public void UIModel_BindValue_SN_WithValue()
        {
            var obj = new UIModelTestClass();
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.SN))
            {
                FormatString = "N2",
                Source = obj,
                BindValue = "123.45678"
            };

            var value = model.BindValue;

            Assert.AreEqual("123.45678", value);
        }

        [TestMethod]
        public void UIModel_BindValue_SN_Null()
        {
            var obj = new UIModelTestClass { SN = "123.45678" };
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.SN))
            {
                FormatString = "N2",
                Source = obj,
                BindValue = null
            };

            var value = model.BindValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_BindValue_S_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.S))
            {
                FormatString = "N2",
            };

            var value = model.BindValue;

            Assert.IsNull(value);
        }

        [TestMethod]
        public void UIModel_BindValue_SN_NoSource()
        {
            var model = new UIModelValue<UIModelTestClass>(nameof(UIModelTestClass.SN))
            {
                FormatString = "N2",
            };

            var value = model.BindValue;

            Assert.IsNull(value);
        }

        #endregion
    }

    internal class UIModelTestClass
    {
        public double D { get; set; }
        public double? DN { get; set; }
        public string S { get; set; } = "";
        public string? SN { get; set; } 
    }
}
