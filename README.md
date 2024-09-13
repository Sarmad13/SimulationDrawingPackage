Design Decisions
================

1.	Dependency Injection: DI is used to improve testability, extensibility, and to follow the Dependency Inversion Principle.
2.	appsettings.json: Widget configurations are moved to appsettings.json to make the system more robust and configurable. This follows the Open/Closed Principle (OCP) by allowing new configurations without modifying the code.
3.	Factory Pattern: The WidgetFactory abstracts the creation logic for each widget, adhering to the Single Responsibility Principle (SRP) and Open/Closed Principle (OCP).
4.	SOLID Principles: The overall architecture adheres to SOLID principles, promoting maintainability and robustness to future changes.

With current design If we introduce new widget type into our application then we need to put in appsettings and WidgetConfig file, update in factory method.

Potential Improvements
======================

• Dynamic Widget Loading: In the future, we could enhance the system by using reflection or a plugin architecture to dynamically load new widget types from assemblies.
like below in WidgetFactory (it will decouple from concrete types and dynamic widgets creation because factory can read configurations)
var type = assembly.GetTypes()
                    .FirstOrDefault(t => t.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase)
                    && typeof(IWidget).IsAssignableFrom(t));
but the reflection violates the DIP by tightly coupling the factory to the names of specific classes at runtime, even if this coupling is hidden also the hidden errors at runtime and reduced readability and maintainability

• Rendering Engine: A possible extension could include actual rendering of the widgets, e.g., to an SVG or image format.
• Error Handling: Currently, the system throws exceptions for invalid configurations. Adding a more robust error-handling mechanism could improve reliability.

This solution ensures that the design is modular, flexible, and testable while adhering to SOLID principles and meeting the requirements for maintainability and extensibility.