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
run.simple:
	docker compose build sharpconsole.simple
	docker compose run --rm sharpconsole.simple

# Run the entity container
run.entity.inmemory:
	docker compose build sharpconsole.entity.inmemory
	docker compose run --rm sharpconsole.entity.inmemory
