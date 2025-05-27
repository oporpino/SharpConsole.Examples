.PHONY: run build clean

# Default target
all: build run

# Build the container
build:
	docker compose build

# Clean up containers and volumes
clean:
	docker compose down -v

# Run the simple container
run.examples.simple:
	docker compose build sharpconsole.examples.simple
	docker compose run --rm sharpconsole.examples.simple

# Run the entity container
run.examples.entity-inmemory:
	docker compose build sharpconsole.examples.entity-inmemory
	docker compose run --rm sharpconsole.examples.entity-inmemory
