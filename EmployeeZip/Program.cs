//***
// Action
//   - Define a cpEmployee (FirstName, LastName)
//   - Keep track of the number of cpEmployees
//   - A constructor, destructor and a counter
// Created
//   - CopyPaste – 20220308 – VVDW
// Changed
//   - CopyPaste – yyyymmdd – VVDW – What changed
// Tested
//   - CopyPaste – 20220308 – VVDW
// Proposal (To Do)
//   -
//***

using System;

namespace CopyPaste.Learning.Toolkit
{

    public class cpEmployee
    {

        #region "Constructors / Destructors"

        public cpEmployee(string strFirstName, string strLastName)
        //***
        // Action
        //   - Create a new instance of cpEmployee
        //   - Defines a firstname and lastname
        //   - Keep track of the number of cpEmployees
        // Called by
        //   - modShared.Main()
        // Calls
        //   - 
        // Created
        //   - CopyPaste – 20220308 – VVDW
        // Changed
        //   - CopyPaste – yyyymmdd – VVDW – What changed
        // Tested
        //   - CopyPaste – 20220308 – VVDW
        // Keyboard key
        //   - 
        // Proposal (To Do)
        //   - 
        //***
        {
            mstrFirstName = strFirstName;
            mstrLastName = strLastName;
            glngCount += 1;
            Console.WriteLine("Employee object constructor: " + mstrFirstName + " " + mstrLastName + "; count = " + glngCount + "\n");
        }
        // cpEmployee(string, string)

        ~cpEmployee()
        //***
        // Action
        //   - Destroys an instance of cpEmployee
        //   - Keep track of the number of cpEmployees
        // Called by
        //   - modShared.Main()
        // Calls
        //   - 
        // Created
        //   - CopyPaste – 20220308 – VVDW
        // Changed
        //   - CopyPaste – yyyymmdd – VVDW – What changed
        // Tested
        //   - CopyPaste – 20220308 – VVDW
        // Keyboard key
        //   - 
        // Proposal (To Do)
        //   - 
        //***
        {
            glngCount -= 1;
            Console.WriteLine("Employee object finalizer: " + mstrFirstName + " " + mstrLastName + "; count = " + glngCount);
            Console.ReadKey();
        }
        // ~cpEmployee()

        #endregion

        //#region "Designer"
        //#endregion

        //#region "Structures"
        //#endregion

        #region "Fields"

        static int glngCount;
        private string mstrFirstName;
        private string mstrLastName;

        #endregion

        #region "Properties"

        public static int Count
        {

            get
            //***
            // Action Get
            //   - Return glngCount
            // Called by
            //   - modShared.Main()
            // Calls
            //   - 
            // Created
            //   - CopyPaste – 20220308 – VVDW
            // Changed
            //   - CopyPaste – yyyymmdd – VVDW – What changed
            // Tested
            //   - CopyPaste – 20220308 – VVDW
            // Keyboard key
            //   - 
            // Proposal (To Do)
            //   - 
            //***
            {
                return glngCount;
            }
            // int Count (Get)

        }
        // int Count

        public string FirstName
        //***
        // Action Get
        //   - Return mstrFirstName
        // Called by
        //   - modShared.Main()
        // Calls
        //   - 
        // Created
        //   - CopyPaste – 20220308 – VVDW
        // Changed
        //   - CopyPaste – yyyymmdd – VVDW – What changed
        // Tested
        //   - CopyPaste – 20220308 – VVDW
        // Keyboard key
        //   - 
        // Proposal (To Do)
        //   - 
        //***
        {

            get
            {
                return mstrFirstName;
            }
            // string FirstName (Get)

        }
        // string FirstName

        public string LastName
        //***
        // Action Get
        //   - Return mstrLastName
        // Called by
        //   - modShared.Main()
        // Calls
        //   - 
        // Created
        //   - CopyPaste – 20220308 – VVDW
        // Changed
        //   - CopyPaste – yyyymmdd – VVDW – What changed
        // Tested
        //   - CopyPaste – 20220308 – VVDW
        // Keyboard key
        //   - 
        // Proposal (To Do)
        //   - 
        //***
        {

            get
            {
                return mstrLastName;
            }
            // string LastName (Get)

        }
        // string LastName

        #endregion

        //#region "Methods"

        //#region "Overrides"
        //#endregion

        //#region "Controls"
        //#endregion

        //#region "Functionality"

        //#region "Event"
        //#endregion

        //#region "Sub / Function"
        //#endregion

        //#endregion

        //#endregion

        //#region "Not used"
        //#endregion

    }
    // cpEmployee

}
// CopyPaste.Learning.Toolkit