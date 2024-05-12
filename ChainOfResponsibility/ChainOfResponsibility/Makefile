# Define variables
SOURCES = Program.cs \
          Priority.cs \
          AbstractHandler.cs \
          LowPriorityHandler.cs \
          MediumPriorityHandler.cs \
          HighPriorityHandler.cs \
          Ticket.cs

OUTPUT = ChainOfResponsibility.exe
CSC = csc

# Default target
all: $(OUTPUT)

# Compile C# program
$(OUTPUT): $(SOURCES)
    $(CSC) /out:$@ $^

# Clean target to remove generated files
clean:
    del $(OUTPUT)
